using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace OxyCommitParser
{
    public class ENoCore : Exception
    {
        public ENoCore() :
            base("This is not a valid xrCore library, Win32 image or there's no library at all!")
        {
        }
    }

    public class ENoEntryPoint : Exception
    {
        public ENoEntryPoint() :
            base("This xrCore library is too old, invalid or not supposed to be used as updateable!")
        {
        }
    }

    public static class Utils
    {
        public const string BaseApi = "https://api.github.com/repos/xrOxygen/xray-oxygen/";

        [DllImport("kernel32.dll")]
        private static extern IntPtr LoadLibrary(string dllToLoad);

        [DllImport("kernel32.dll")]
        private static extern IntPtr GetProcAddress(IntPtr hModule, string procedureName);

        [DllImport("kernel32.dll")]
        private static extern bool FreeLibrary(IntPtr hModule);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        delegate IntPtr GetCurrentHashDelegate();

        public static T DownloadSerializedJsonData<T>(string url) where T : class
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
            request.UserAgent = "OxyCommitParser";

            try
            {
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader =
                    new StreamReader(stream ?? throw new NullReferenceException("Response stream is null.")))
                {
                    string str = reader.ReadToEnd();

                    T rawData = JsonConvert.DeserializeObject<T>(str);

                    return rawData;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                // Need to revise

                //Application.Exit();
            }

            return default;
        }

        public static string GetLocalReleaseHash(string corePath)
        {
            IntPtr libHandle = LoadLibrary(corePath.Trim());

            if (libHandle == IntPtr.Zero)
                throw new ENoCore();

            IntPtr procAddress = GetProcAddress(libHandle, "GetCurrentHash");
            if (procAddress == IntPtr.Zero)
                throw new ENoEntryPoint();

            GetCurrentHashDelegate getLocalHash =
                Marshal.GetDelegateForFunctionPointer<GetCurrentHashDelegate>(procAddress);

            string localHash = Marshal.PtrToStringAnsi(getLocalHash());

            FreeLibrary(libHandle);

            return localHash;
        }

        internal static Release GetLatestRelease() =>
            DownloadSerializedJsonData<Release>($"{BaseApi}releases/latest");

        internal static Release GetReleaseByHash(string hash)
        {
            List<Release> releases =
                DownloadSerializedJsonData<List<Release>>($"{BaseApi}releases");

            return releases?.FirstOrDefault(r => r.Hash.StartsWith(hash));
        }

        public static void CopyFolder(string sourceFolder, string destFolder)
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
}
