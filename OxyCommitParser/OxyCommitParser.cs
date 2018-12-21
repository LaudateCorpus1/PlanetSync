namespace OxyCommitParser
{
    static class OxyCommitParser
    {
        internal static CommitQueryResponse GetCommitByHash(string hash)
        {
            string url = $"{Utils.BaseApi}commits/{hash}";

            CommitQueryResponse rawCommit = Utils.DownloadSerializedJsonData<CommitQueryResponse>(url);

            return rawCommit;
        }
	}
}
