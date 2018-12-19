using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace OxyCommitParser
{
    public class ENoCore : Exception
    {
        public ENoCore() : 
            base("This is not a valid xrCore library, Win32 image or there's no library at all!")
        { }
    }

    public class ENoEntryPoint : Exception
    {
        public ENoEntryPoint() :
            base("This xrCore library is too old, invalid or not supposed to be used as updatable!")
        { }
    }


    public static class Utils
    {
        [DllImport("kernel32.dll")]
        public static extern IntPtr LoadLibrary(string dllToLoad);

        [DllImport("kernel32.dll")]
        public static extern IntPtr GetProcAddress(IntPtr hModule, string procedureName);

        [DllImport("kernel32.dll")]
        public static extern bool FreeLibrary(IntPtr hModule);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        delegate IntPtr GetCurrentHashDelegate();

        public static T DownloadSerializedJsonData<T>(string url) where T : class
        {
            Uri address = new Uri(url);

            using (var w = new WebClient())
            {
                w.Headers["User-Agent"] = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/69.0.3497.100 Safari/537.36";

                var json_data = string.Empty;

                try
                {
                    json_data = w.DownloadString(url);
                }
                catch (Exception) {
                    return null;
                }

                return !string.IsNullOrEmpty(json_data) ? JsonConvert.DeserializeObject<T>(json_data) : null;
            }
        }

        public static string GetReleaseHash(string corePath)
        {
            IntPtr libHandle = LoadLibrary(corePath.Trim());

            if (libHandle == IntPtr.Zero)
                throw new ENoCore();

            IntPtr procAddress = GetProcAddress(libHandle, "GetCurrentHash");
            if (procAddress == IntPtr.Zero)
                throw new ENoEntryPoint();

            GetCurrentHashDelegate GetLocalHash = Marshal.GetDelegateForFunctionPointer<GetCurrentHashDelegate>(procAddress);

            var localHash = Marshal.PtrToStringAnsi(GetLocalHash());

            FreeLibrary(libHandle);
            
            return localHash.ToString();
        }

        public static GithubRelease GetRemoteRelease()
        {
            return DownloadSerializedJsonData<GithubRelease>("https://api.github.com/repos/xrOxygen/xray-oxygen/releases/latest");
        }

        public static GithubRelease GetRemoteRelease(string hash)
        {
            GithubRelease[] releases = DownloadSerializedJsonData<GithubRelease[]>("https://api.github.com/repos/xrOxygen/xray-oxygen/releases");

            GithubRelease release = null;

            foreach (GithubRelease item in releases)
            {
                if (!item.target_commitish.StartsWith(hash)) continue;
                release = item;
                break;
            }

            return release;
        }

        static public void CopyFolder(string sourceFolder, string destFolder)
        {
            if (!Directory.Exists(destFolder))
                Directory.CreateDirectory(destFolder);
            string[] files = Directory.GetFiles(sourceFolder);
            foreach (string file in files)
            {
                string name = Path.GetFileName(file);
                string dest = Path.Combine(destFolder, name);
                File.Copy(file, dest, true);
            }
            string[] folders = Directory.GetDirectories(sourceFolder);
            foreach (string folder in folders)
            {
                string name = Path.GetFileName(folder);
                string dest = Path.Combine(destFolder, name);
                CopyFolder(folder, dest);
            }
        }
    }

	internal class Commit
	{
		public string Hash { get; set; }
		public string Author { get; set; }
		public string Message { get; set; }
		public DateTime Date { get; set; }
	}

	internal class Result
	{
		internal enum RepoState
		{
			UpToDate,
			NewUpdates,

			Error
		}

		public RepoState State;
		public Commit Data;
	}

	static class OxyCommitParser
	{
		private static List<dynamic> Get(string uri)
		{
			HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
			request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
			request.UserAgent = "OxyCommitParser";

			try
			{
				using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
				using (Stream stream = response.GetResponseStream())
				using (StreamReader reader =
					new StreamReader(stream ?? throw new NullReferenceException("Response stream is null.")))
				{
					var str = reader.ReadToEnd();

					var rawCommits = JsonConvert.DeserializeObject<List<dynamic>>(str);

					return rawCommits;
				}
			}
			catch (WebException)
			{
				return null;
			}

		}

		public static Result CheckUpdates(string compareCommitHash = "null", string branch = "ox_dev")
		{
			string uri = $"https://api.github.com/repos/xrOxygen/xray-oxygen/commits?sha={branch}";
			string uri2 = $"https://api.github.com/repos/xrOxygen/xray-oxygen/commits?sha={compareCommitHash}";

			var lastCommit = compareCommitHash.Equals("null", StringComparison.InvariantCulture) ? Get(uri)[0] : Get(uri2)[0];

			if (lastCommit == null)
				return new Result()
				{
					State = Result.RepoState.Error,
					Data = null
				};

			string lastCommitHash = lastCommit.sha;
			
			return new Result
			{
				State = Result.RepoState.NewUpdates,
				Data = new Commit
				{
					Author = lastCommit.commit.author.name,
					Hash = lastCommitHash,
					Message = lastCommit.commit.message,
					Date = DateTime.Parse(lastCommit.commit.author.date.ToString())
				}
			};
		}
	}
}
