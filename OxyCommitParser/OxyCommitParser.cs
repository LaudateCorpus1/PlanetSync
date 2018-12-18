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
        NewUpdates
    }

    internal class Commit
    {
        public string Hash { get; set; }
        public string Author { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set; }
    }

    internal class Result<T>
    {
        public RepoState State;
        public T Data;
    }

    static class OxyCommitParser
    {
        private static List<dynamic> Get(string uri)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
            request.UserAgent = "OxyCommitParser";

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream ?? throw new NullReferenceException("Response stream is null.")))
            {
                var str = reader.ReadToEnd();

                var rawCommits = JsonConvert.DeserializeObject<List<dynamic>>(str);

                return rawCommits;
            }
        }

        public static Result<Commit> CheckUpdates(string compareCommitHash, string branch = "ox_dev")
        {
            string uri = $"https://api.github.com/repos/xrOxygen/xray-oxygen/commits?sha={branch}";

            var lastCommit = Get(uri)[0];
            string lastCommitHash = lastCommit.sha;

            if (compareCommitHash.Equals(lastCommitHash, StringComparison.InvariantCulture))
            {
                return new Result<Commit>
                {
                    Data = null,
                    State = RepoState.UpToDate
                };
            }

            return new Result<Commit>
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
