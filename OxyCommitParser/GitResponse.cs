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

    internal class Asset
    {
        [JsonProperty(PropertyName = "browser_download_url")]
        public string Url { get; set; }
    }

    internal class CommitResponse
    {
        [JsonProperty(PropertyName = "commit")]
        public CommitInfo CommitInfo { get; set; }

        [JsonProperty(PropertyName = "author")]
        public Author Author { get; set; }
    }

    internal class Author
    {
        [JsonProperty(PropertyName = "login")]
        public string Login { get; set; }

        [JsonProperty(PropertyName = "avatar_url")]
        public string Avatar { get; set; }
    }

    internal class CommitInfo
    {
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }
        
        [JsonProperty(PropertyName = "author")]
        public AuthorDetails AuthorDetails { get; set; }
    }

    internal class AuthorDetails
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        [JsonProperty(PropertyName = "date")]
        public DateTime Date { get; set; }
    }
}
