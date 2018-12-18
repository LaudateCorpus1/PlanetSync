using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OxyCommitParser
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			string CURRENT_COMMIT = "614be6d36f477349f766fb69a1bf9671e3241a58";
			
			var CommitInfo = OxyCommitParser.CheckUpdates(CURRENT_COMMIT);
			var CommitMsg = CommitInfo.Data.Message.Split('\n');

			string NewCommitMessage = "";
			for (int i = 0; i < CommitMsg.Length; i++)
			{
				if(CommitMsg[i].Length > 78)
				{
					CommitMsg[i] = CommitMsg[i].Substring(0, 75) + "-\n          " + CommitMsg[i].Substring(76);
				}
				NewCommitMessage += CommitMsg[i] + "\n";
			}

			this.CommitText.Text = NewCommitMessage;
			this.CommitAuthor.Text = CommitInfo.Data.Author;
			this.CommitDate.Text = CommitInfo.Data.Date.ToString();
		}
	}
}
