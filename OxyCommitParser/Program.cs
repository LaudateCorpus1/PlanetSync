using System;
using System.Net;

namespace OxyCommitParser
{
	class Program
	{
		[STAThread]
		static void Main(string[] args)
		{
            // Little magic for https enabling
            ServicePointManager.ServerCertificateValidationCallback += (_sender, cert, chain, error) =>
            {
                return error == System.Net.Security.SslPolicyErrors.None;
            };
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | (SecurityProtocolType)3072;

            System.Windows.Forms.Application.EnableVisualStyles();
			System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
			System.Windows.Forms.Application.Run(new MainForm());
		}
	}
}
