using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Net;
using SevenZipExtractor;
using System.ComponentModel;

namespace OxyCommitParser
{
	public partial class MainForm : Form
	{
        string corePath = "";
        string tempDir = "";
        string tempFile = "";

        public MainForm()
		{
			InitializeComponent();
		}

		private string HelperTextGen(string text)
		{
			string NewCommitMessage = "";
			try
			{
				var CommitMsg = text.Split('\n');

				for (int i = 0; i < CommitMsg.Length; i++)
				{
					if (CommitMsg[i].Length > 78)
					{
						CommitMsg[i] = CommitMsg[i].Substring(0, 75) + "-\n          " + CommitMsg[i].Substring(76);
					}
					NewCommitMessage += CommitMsg[i] + "\n";
				}
			}
			catch (Exception)
			{
				NewCommitMessage = text;
			}
			return NewCommitMessage;
		}

		void wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            pbUpdate.Value = e.ProgressPercentage;
        }

        private void wc_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            pbUpdate.Visible = false;
            pbUpdate.Value = 0;

            string coreFolder = System.IO.Path.GetDirectoryName(corePath);
            coreFolder = System.IO.Path.GetFullPath(System.IO.Path.Combine(coreFolder, @"..\"));

            using (ArchiveFile archiveFile = new ArchiveFile(tempFile))
            {
                archiveFile.Extract(tempDir);
            }

            tempDir = System.IO.Path.GetFullPath(System.IO.Path.Combine(tempDir, @"game\"));

            Utils.CopyFolder(tempDir, coreFolder);

            System.IO.File.Delete(tempFile);

            Application.Restart();
        }

        private void DownloadUpdate(string url, string dest)
        {
            pbUpdate.Visible = true;
            using (WebClient w = new WebClient())
            {
                w.Headers["User-Agent"] = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/69.0.3497.100 Safari/537.36";
                w.DownloadProgressChanged += wc_DownloadProgressChanged;
                w.DownloadFileCompleted += wc_DownloadFileCompleted;
                w.DownloadFileAsync(new Uri(url), dest);
            }
        }

        private void MainForm_Shown(object sender, EventArgs ea)
        {
            // Looking for xrCore...
            corePath = "xrCore.dll";
            bool isUpToDate = false;
            if (!System.IO.File.Exists(corePath))
            {
                if (searchCoreDialog.ShowDialog() != DialogResult.OK) return;
                corePath = searchCoreDialog.FileName;
            }

            // Retrieving local commit info...
            string localHash = "";
            try
            {
                localHash = Utils.GetReleaseHash(corePath);
            }
            catch (ENoCore e)
            {
                this.lcommitText.Text = e.Message;
                this.lcommitDate.Text = DateTime.Now.ToString();
				this.lcommitAuthor.Text = "";
            }
            catch (ENoEntryPoint e)
            {
                this.lcommitText.Text = e.Message;
                this.lcommitDate.Text = DateTime.Now.ToString();
				this.lcommitAuthor.Text = "";
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.lcommitDate.Text = DateTime.Now.ToString();
				this.lcommitAuthor.Text = "";
            }

			GithubRelease LocalReleaseInfo = null;
			Result LocalCommitInfo = null;
			if (localHash != "")
            {
				// Getting info for local commit from GitHub
				LocalReleaseInfo = Utils.GetRemoteRelease(localHash);
                if (LocalReleaseInfo == null)
                {
					LocalCommitInfo = OxyCommitParser.CheckUpdates(localHash);
					this.lcommitText.Text = HelperTextGen(LocalCommitInfo.Data.Message);
					this.lcommitDate.Text = LocalCommitInfo.Data.Date.ToString();
					this.lcommitAuthor.Text = LocalCommitInfo.Data.Author;
					this.lcommiteeAvatar.LoadAsync(LocalCommitInfo.Data.Avatar);
				}
                else
                {
                    this.lcommiteeAvatar.LoadAsync(LocalReleaseInfo.author.avatar_url);
                    this.gbLocal.Text = LocalReleaseInfo.name;
                    this.lcommitAuthor.Text = LocalReleaseInfo.author.login;
                    this.lcommitText.Text = String.IsNullOrWhiteSpace(LocalReleaseInfo.body) ? "No description available" : LocalReleaseInfo.body.Replace("\r\n", Environment.NewLine);
					this.lcommitDate.Text = LocalReleaseInfo.published_at.ToString();
                }
            }

            // Getting latest release...
            GithubRelease latest = Utils.GetRemoteRelease();

            this.rcommiteeAvatar.LoadAsync(latest.author.avatar_url);
            this.LastReleaseName.Text = latest.name;
            this.rcommitAuthor.Text = latest.author.login;
            this.rcommitText.Text = String.IsNullOrWhiteSpace(latest.body) ? "No description available" : latest.body.Replace("\r\n", Environment.NewLine);
            this.rcommitDate.Text = latest.published_at.ToString();

            isUpToDate = latest.target_commitish.StartsWith(localHash);

            // Ask for update if not up to date...
            if (isUpToDate) return;
            if (latest.assets.Length == 0) return;
			if (LocalReleaseInfo != null && latest.published_at < LocalReleaseInfo.published_at) return;
			if (LocalCommitInfo != null) return;
            if (MessageBox.Show("Update to recent release?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            // Do download...
            Asset downloadableAsset = null;
            foreach (Asset item in latest.assets)
            {
                if (item.browser_download_url.EndsWith(".zip") || item.browser_download_url.EndsWith(".7z"))
                {
                    downloadableAsset = item;
                    break;
                }
            }

            if (downloadableAsset == null)
            {
                rcommitText.Text = "Unable to find release zip file!";
                return;
            }

            // Prepare...
            tempFile = System.IO.Path.GetTempPath();
            if (tempFile.EndsWith("\\") == false)
            {
                tempFile += "\\";
            }

            string unixTimeNow = ((Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds).ToString();
            tempDir = $"{tempFile}oxy_{unixTimeNow}\\";
            string[] parts = downloadableAsset.browser_download_url.Split('.');
            string ext = parts[parts.Length - 1];
            tempFile += unixTimeNow + "_oxy."+ext;

            // Download and unpack on download complete
            DownloadUpdate(downloadableAsset.browser_download_url, tempFile);
        }
    }
}
