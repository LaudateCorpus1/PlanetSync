using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using SevenZipExtractor;

namespace OxyCommitParser
{
    
    public partial class MainForm : Form
    {
        private const string ErrorMessage = "Something went wrong. \nAdditional info:{0}";

        string _corePath = "";
        string _tempDir = "";
        string _tempFile = "";

        public MainForm()
        {
            InitializeComponent();
            SetSettingsValues();
        }

        private string HelperTextGen(string text)
        {
            string newCommitMessage = "";

            try
            {
                var commitMsg = text.Split('\n');

                for (int i = 0; i < commitMsg.Length; i++)
                {
                    if (commitMsg[i].Length > 78)
                    {
                        commitMsg[i] = commitMsg[i].Substring(0, 75) + "-\n          " + commitMsg[i].Substring(76);
                    }

                    newCommitMessage += commitMsg[i] + "\n";
                }
            }
            catch (Exception)
            {
                newCommitMessage = text;
            }

            return newCommitMessage;
        }

        void wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
            => pbUpdate.Value = e.ProgressPercentage;

        private void wc_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            pbUpdate.Visible = false;
            pbUpdate.Value = 0;

            string coreFolder = Path.GetDirectoryName(_corePath);
            coreFolder = Path.GetFullPath(Path.Combine(coreFolder, @"..\"));

            using (ArchiveFile archiveFile = new ArchiveFile(_tempFile))
            {
                archiveFile.Extract(_tempDir);
            }

            _tempDir = Path.GetFullPath(Path.Combine(_tempDir, @"game\"));

            Utils.CopyFolder(_tempDir, coreFolder);

            File.Delete(_tempFile);

            Application.Restart();
        }

        private void DownloadUpdate(string url, string dest)
        {
            pbUpdate.Visible = true;
            using (WebClient w = new WebClient())
            {
                w.Headers["User-Agent"] =
                    "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/69.0.3497.100 Safari/537.36";
                w.DownloadProgressChanged += wc_DownloadProgressChanged;
                w.DownloadFileCompleted += wc_DownloadFileCompleted;
                w.DownloadFileAsync(new Uri(url), dest);
            }
        }

        private void MainForm_Shown(object sender, EventArgs ea)
        {
            // Looking for xrCore...
            _corePath = "xrCore.dll";

            if (!File.Exists(_corePath))
            {
                if (!Properties.Settings.Default.isRememberLibPath || !File.Exists(Properties.Settings.Default.xrCorePath))
                {
                    if (searchCoreDialog.ShowDialog() != DialogResult.OK) return;
                    _corePath = searchCoreDialog.FileName;

                    if (Properties.Settings.Default.isRememberLibPath)
                    {
                        Properties.Settings.Default.xrCorePath = _corePath;
                        Properties.Settings.Default.Save();
                    }
                }
                else
                {
                    _corePath = Properties.Settings.Default.xrCorePath;
                }
            }

            // Retrieving local commit info...
            string localHash = string.Empty;

            try
            {
                localHash = Utils.GetLocalReleaseHash(_corePath);
            }

            catch (Exception ex) when (ex is ENoCore || ex is ENoEntryPoint)
            {
                lcommitText.Text = ex.Message;
                lcommitDate.Text = DateTime.Now.ToString();
                lcommitAuthor.Text = "";
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lcommitDate.Text = DateTime.Now.ToString();
                lcommitAuthor.Text = "";
            }

            Release localReleaseInfo = null;
            CommitResponse localCommitInfo = null;

            if (!string.IsNullOrEmpty(localHash))
            {
                // Getting info for local release from GitHub

                localReleaseInfo = Utils.GetReleaseByHash(localHash);

                if (localReleaseInfo != default(Release))
                {
                    gbLocal.Text = localReleaseInfo.Name;

                    lcommitText.Text = string.IsNullOrWhiteSpace(localReleaseInfo.Message)
                        ? "No description available"
                        : localReleaseInfo.Message.Replace("\r\n", Environment.NewLine);

                    lcommitDate.Text = localReleaseInfo.PublishedDate.ToString(CultureInfo.InvariantCulture);
                    lcommitAuthor.Text = localReleaseInfo.Author.Login;
                    lcommiteeAvatar.LoadAsync(localReleaseInfo.Author.Avatar);
                }
                else
                {
                    // get info about release commit, if didn't find in releases 

                    localCommitInfo = OxyCommitParser.GetCommitByHash(localHash);

                    if (localCommitInfo != default(CommitResponse))
                    {
                        lcommitText.Text = HelperTextGen(localCommitInfo.CommitInfo.Message);
                        lcommitDate.Text =
                            localCommitInfo.CommitInfo.AuthorDetails.Date.ToString(CultureInfo.InvariantCulture);
                        lcommitAuthor.Text = localCommitInfo.Author.Login;
                        lcommiteeAvatar.LoadAsync(localCommitInfo.Author.Avatar);
                    }
                    else
                    {
                        MessageBox.Show(string.Format(ErrorMessage, "Error in getting local commit info"));
                    }
                }
            }

            ManageLatestRelease(localHash, localReleaseInfo, localCommitInfo);
        }

        private void ManageLatestRelease(string localHash, Release localReleaseInfo, CommitResponse localCommitInfo)
        {
            Release latestRelease = Utils.GetLatestRelease();

            if (latestRelease != default(Release))
            {
                rcommiteeAvatar.LoadAsync(latestRelease.Author.Avatar);
                LastReleaseName.Text = latestRelease.Name;
                rcommitAuthor.Text = latestRelease.Author.Login;
                rcommitText.Text = string.IsNullOrWhiteSpace(latestRelease.Message)
                    ? "No description available"
                    : latestRelease.Message.Replace("\r\n", Environment.NewLine);
                rcommitDate.Text = latestRelease.PublishedDate.ToString(CultureInfo.InvariantCulture);

                UpdateLocalRelease(localHash, latestRelease, localReleaseInfo, localCommitInfo);
            }
            else
            {
                MessageBox.Show(string.Format(ErrorMessage, "Error in getting last release. Please, try again later."));
            }
        }

        private void UpdateLocalRelease(string localHash, Release latestRelease, Release localReleaseInfo, CommitResponse localCommitInfo)
        {
            bool isUpToDate = latestRelease.Hash.StartsWith(localHash);

			// Ask for update if not up to date...

			if(localReleaseInfo != null && latestRelease.PublishedDate <= localReleaseInfo.PublishedDate)
			{
				if (isUpToDate || latestRelease.Assets.Length == 0 || localCommitInfo != null)
					return;
			}

            if (MessageBox.Show("Update to recent release?", "Update", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.No)
                return;

            // Do download...

            Asset asset =
                latestRelease.Assets.FirstOrDefault(ast => ast.Url.EndsWith(".zip") || ast.Url.EndsWith(".7z"));

            if (asset == default(Asset))
            {
                rcommitText.Text = "Unable to find release zip file!";
                return;
            }

            // Prepare...
            _tempFile = Path.GetTempPath();
            if (_tempFile.EndsWith("\\") == false)
            {
                _tempFile += "\\";
            }

            string unixTimeNow = ((int)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds).ToString();
            _tempDir = $"{_tempFile}oxy_{unixTimeNow}\\";
            string[] parts = asset.Url.Split('.');
            string ext = parts[parts.Length - 1];
            _tempFile += unixTimeNow + "_oxy." + ext;

            // Download and unpack on download complete
            DownloadUpdate(asset.Url, _tempFile);
        }

        private void cbRememberPath_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.isRememberLibPath = cbRememberPath.Checked;
            Properties.Settings.Default.Save();

            //Application.Restart();
        }

        private void SetSettingsValues() => cbRememberPath.Checked = Properties.Settings.Default.isRememberLibPath;

        private void MainForm_MouseDown(object sender, MouseEventArgs e){}

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            NativeMethods.ReleaseCapture();
            NativeMethods.PostMessage(this.Handle, 0x0112, (IntPtr)0xF012, (IntPtr)0);
        }

        private void exitLabel_MouseEnter(object sender, EventArgs e)
        {
            exitLabel.BackColor = Color.FromArgb(255, 92, 31);
        }

        private void exitLabel_MouseLeave(object sender, EventArgs e)
        {
            exitLabel.BackColor = Color.FromArgb(255, 0, 0);
        }

        private void exitLabel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void minimazeLabel_Click(object sender, EventArgs e)
        {
            base.WindowState = FormWindowState.Minimized;
        }

        private void minimazeLabel_MouseEnter(object sender, EventArgs e)
        {
            minimazeLabel.BackColor = Color.FromArgb(255, 197, 44);
        }

        private void minimazeLabel_MouseLeave(object sender, EventArgs e)
        {
            minimazeLabel.BackColor = Color.FromArgb(255, 128, 0);
        }

		private void gbSettings_Enter(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			string ExePath = _corePath.Substring(0, _corePath.Length - "xrCore.dll".Length);

			System.Diagnostics.Process pApp = new System.Diagnostics.Process();
			pApp.StartInfo.FileName = ExePath + "xrPlay.exe";
			pApp.StartInfo.WorkingDirectory = ExePath;
			pApp.Start();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Release latestRelease = Utils.GetLatestRelease();
			UpdateLocalRelease("8bef5e6", latestRelease, Utils.GetReleaseByHash("8bef5e6"), null);
		}
	}
	public static class NativeMethods
    {
        [DllImport("user32", CharSet = CharSet.Auto)]
        internal extern static bool PostMessage(IntPtr hWnd, uint Msg, IntPtr WParam, IntPtr LParam);

        [DllImport("user32", CharSet = CharSet.Auto)]
        internal extern static bool ReleaseCapture();
    }

}
