using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace OxyCommitParser
{
    enum eCheckResult
    {
        UP_TO_DATE,
        NEW_VERSION,

        FAILED
    }

    struct OxyCommit
    {
        string hash,
               author,
               message;
    }

    class CheckResult
    {
        eCheckResult checkResult;

        OxyCommit[] commits;
    }


    class OxyCommitParser
    {
        public static string Get(string uri)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
           // request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }


        public static CheckResult ParseUpdates(string commit)
        {
            var resultate = new CheckResult();

            dynamic jsonObjRaw = JsonConvert.DeserializeObject(Get("https://api.github.com/repos/xrOxygen/xray-oxygen/commits"));

            foreach (var objct in jsonObjRaw)
            {
                Console.WriteLine(objct.sha);
            }

            return resultate;
        }
    }
}
