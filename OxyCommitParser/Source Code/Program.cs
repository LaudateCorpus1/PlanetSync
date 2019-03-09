using System;
using System.Net;
using System.Net.Security;
using System.Windows.Forms;

namespace OxyCommitParser
{
	class Program
	{
	    [STAThread]
	    static void Main(string[] args)
	    {
	        // Little magic for https enabling
	        ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, error) =>
	            error == SslPolicyErrors.None;

	        ServicePointManager.SecurityProtocol =	/* What the heck is "(SecurityProtocolType) 3072"? */
	            SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | (SecurityProtocolType) 3072;

	        Application.EnableVisualStyles();
	        Application.SetCompatibleTextRenderingDefault(false);
	        Application.Run(new MainForm());
	    }
	}
}
