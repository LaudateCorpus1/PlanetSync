using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace OxyCommitParser
{
    internal enum RepoState
    {
        UpToDate,
        NewUpdates,

        Error
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
                using (HttpWebResponse response = (HttpWebResponse) request.GetResponse())
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

            if (lastCommit = null)
                return new Result()
                {
                    State = RepoState.Error,
                    Data = null
                };

            string lastCommitHash = lastCommit.sha;

			if (compareCommitHash.Equals(lastCommitHash, StringComparison.InvariantCulture))
			{
			    return new Result
			    {
			        State = RepoState.UpToDate,
			        Data = null
			    };
			}

			return new Result
            {
                State = RepoState.NewUpdates,
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
