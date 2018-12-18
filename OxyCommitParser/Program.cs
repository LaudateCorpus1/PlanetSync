using System;

namespace OxyCommitParser
{
	class Program
	{
		[STAThread]
		static void Main(string[] args)
		{
			//var CURRENT_COMMIT = "614be6d36f477349f766fb69a1bf9671e3241a58";
			//
			//var CommitInfo = OxyCommitParser.CheckUpdates(CURRENT_COMMIT);
			//System.Console.WriteLine(CommitInfo.Data.Message);
			
			System.Windows.Forms.Application.EnableVisualStyles();
			System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
			System.Windows.Forms.Application.Run(new Form1());
		}
	}
}
