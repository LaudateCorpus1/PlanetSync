using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace OxyCommitParser
{
	public partial class Form1 : Form
	{
		private string LocalPath;
		[DllImport("xrCoreWrapper.dll")]
		private static extern IntPtr GetLocalHash(string ModuleName);

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
		public Form1()
		{
			InitializeComponent();
			var CommitInfo = OxyCommitParser.CheckUpdates();

			this.CommitText.Text = HelperTextGen(CommitInfo.Data.Message);
			this.CommitAuthor.Text = CommitInfo.Data.Author;
			this.CommitDate.Text = CommitInfo.Data.Date.ToString();

			LocalPath = "";
		}

		private void button1_Click(object sender, EventArgs e)
		{
			openFileDialog1.FileName = "xrCore.dll";
			openFileDialog1.Multiselect = false;

			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				this.button1.Visible = false;
				IntPtr CurrHash = GetLocalHash(openFileDialog1.FileName);
				string currentCommitHash = Marshal.PtrToStringAnsi(CurrHash);
				var CurCommitInfo = OxyCommitParser.CheckUpdates(currentCommitHash);

				this.CurCommitMsg.Text = HelperTextGen(CurCommitInfo.Data.Message);
				this.CurCommitAuthor.Text = CurCommitInfo.Data.Author;
				this.CurCommitDate.Text = CurCommitInfo.Data.Date.ToString();

				this.CurCommitMsg.Visible = true;
				this.CurCommitAuthor.Visible = true;
				this.CurCommitDate.Visible = true;
				this.CurSysCommitAuthorText.Visible = true;
				this.CurSysCommitDate.Visible = true;

				// Load dumps list
				var FoldersList = openFileDialog1.FileName.Split('\\');

				for (Int32 It = 0; It < FoldersList.Length - 2; It++)
				{
					LocalPath += FoldersList[It] + "\\";
				}

				string UserDataPath = LocalPath + "\\userdata\\dumps\\";
				foreach (string file_name in Directory.GetFiles(UserDataPath))
					listBox1.Items.Add(file_name.Substring(UserDataPath.Length + 13).Replace('_', ' '));

				this.IsDumpList.Visible = true;
			}
		}

		private void IsDumpList_CheckedChanged(object sender, EventArgs e)
		{
			listBox1.Visible = this.IsDumpList.Checked;
		}
	}
}
