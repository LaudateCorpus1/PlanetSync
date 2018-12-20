namespace OxyCommitParser
{
    static class OxyCommitParser
    {
        internal static Commit GetCommitByHash(string hash)
        {
            string url = $"{Utils.BaseApi}commits/{hash}";

            var rawCommit = Utils.DownloadSerializedJsonData<dynamic>(url);

            return new Commit(rawCommit);
        }
	}
}
