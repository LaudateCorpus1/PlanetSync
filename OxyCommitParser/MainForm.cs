using System;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
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
                if (!Properties.Settings.Default.isRememberLibPath ||
                    !File.Exists(Properties.Settings.Default.xrCorePath))
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

            if (isUpToDate ||
                latestRelease.Assets.Length == 0 ||
                localReleaseInfo != null && latestRelease.PublishedDate < localReleaseInfo.PublishedDate ||
                localCommitInfo != null)
                return;

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
    }
}
