namespace OxyCommitParser
{
    static class OxyCommitParser
    {
        internal static CommitResponse GetCommitByHash(string hash)
        {
            string url = $"{Utils.BaseApi}commits/{hash}";

            CommitResponse rawCommit = Utils.DownloadSerializedJsonData<CommitResponse>(url);

            return rawCommit;
        }
	}
}
