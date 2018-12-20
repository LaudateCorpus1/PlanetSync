using System;
using Newtonsoft.Json;

namespace OxyCommitParser
{
    internal class Release
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "published_at")]
        public DateTime PublishedDate { get; set; }

        [JsonProperty(PropertyName = "author")]
        public Author Author { get; set; }

        [JsonProperty(PropertyName = "target_commitish")]
        public string Hash { get; set; }

        [JsonProperty(PropertyName = "body")]
        public string Message { get; set; }

        [JsonProperty(PropertyName = "assets")]
        public Asset[] Assets { get; set; }
    }

    internal class Commit
    {
        public string Hash { get; }
        public Author Author { get;  }
        public string Message { get; }
        public DateTime Date { get; }

        public Commit(dynamic rawCommit)
        {
            Hash = rawCommit.sha;
            Author = new Author(rawCommit.author);
            Date = DateTime.Parse(rawCommit.commit.author.date.ToString());
            Message = rawCommit.commit.message;
        }
    }

    public class Author
    {
        [JsonProperty(PropertyName = "login")]
        public string Login { get; set; }
        [JsonProperty(PropertyName = "avatar_url")]
        public string Avatar { get; set; }

        public Author() { }

        public Author(dynamic rawAuthor)
        {
            Login = rawAuthor.login;
            Avatar = rawAuthor.avatar_url;
        }
    }

    public class Asset
    {
        [JsonProperty(PropertyName = "browser_download_url")]
        public string Url { get; set; }
    }

	//internal class Result
	//{
	//	internal enum RepoState
	//	{
	//		UpToDate,
	//		NewUpdates,
	//		Error
	//	}

	//	public RepoState State;
	//	public Commit Data;
	//}
}
