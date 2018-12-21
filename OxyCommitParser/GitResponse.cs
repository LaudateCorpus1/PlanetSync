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
        public CommitAuthor Author { get; set; }

        [JsonProperty(PropertyName = "target_commitish")]
        public string Hash { get; set; }

        [JsonProperty(PropertyName = "body")]
        public string Message { get; set; }

        [JsonProperty(PropertyName = "assets")]
        public Asset[] Assets { get; set; }
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

    public class CommitQueryResponse
    {
        public string url { get; set; }
        public string sha { get; set; }
        public string node_id { get; set; }
        public string html_url { get; set; }
        public string comments_url { get; set; }
        public CommitInfo commit { get; set; }
        public CommitAuthor author { get; set; }
        public Committer committer { get; set; }
        public ParentCommits[] parents { get; set; }
        public Stats stats { get; set; }
        public GithubFile[] files { get; set; }
    }

    public class CommitInfo
    {
        public string url { get; set; }
        public AuthorDetails author { get; set; }
        public CommitInfoCommiter committer { get; set; }
        public string message { get; set; }
        public Tree tree { get; set; }
        public int comment_count { get; set; }
        public Verification verification { get; set; }
    }

    public class AuthorDetails
    {
        public string name { get; set; }
        public string email { get; set; }
        public DateTime date { get; set; }
    }

    public class CommitInfoCommiter
    {
        public string name { get; set; }
        public string email { get; set; }
        public DateTime date { get; set; }
    }

    public class Tree
    {
        public string url { get; set; }
        public string sha { get; set; }
    }

    public class Verification
    {
        public bool verified { get; set; }
        public string reason { get; set; }
        public object signature { get; set; }
        public object payload { get; set; }
    }

    public class CommitAuthor
    {
        public string login { get; set; }
        public int id { get; set; }
        public string node_id { get; set; }
        public string avatar_url { get; set; }
        public string gravatar_id { get; set; }
        public string url { get; set; }
        public string html_url { get; set; }
        public string followers_url { get; set; }
        public string following_url { get; set; }
        public string gists_url { get; set; }
        public string starred_url { get; set; }
        public string subscriptions_url { get; set; }
        public string organizations_url { get; set; }
        public string repos_url { get; set; }
        public string events_url { get; set; }
        public string received_events_url { get; set; }
        public string type { get; set; }
        public bool site_admin { get; set; }
    }

    public class Committer
    {
        public string login { get; set; }
        public int id { get; set; }
        public string node_id { get; set; }
        public string avatar_url { get; set; }
        public string gravatar_id { get; set; }
        public string url { get; set; }
        public string html_url { get; set; }
        public string followers_url { get; set; }
        public string following_url { get; set; }
        public string gists_url { get; set; }
        public string starred_url { get; set; }
        public string subscriptions_url { get; set; }
        public string organizations_url { get; set; }
        public string repos_url { get; set; }
        public string events_url { get; set; }
        public string received_events_url { get; set; }
        public string type { get; set; }
        public bool site_admin { get; set; }
    }

    public class Stats
    {
        public int additions { get; set; }
        public int deletions { get; set; }
        public int total { get; set; }
    }

    public class ParentCommits
    {
        public string url { get; set; }
        public string sha { get; set; }
    }

    public class GithubFile
    {
        public string filename { get; set; }
        public int additions { get; set; }
        public int deletions { get; set; }
        public int changes { get; set; }
        public string status { get; set; }
        public string raw_url { get; set; }
        public string blob_url { get; set; }
        public string patch { get; set; }
    }


}
