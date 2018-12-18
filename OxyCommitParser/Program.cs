namespace OxyCommitParser
{
    class Program
    {
        static void Main(string[] args)
        {
            var CURRENT_COMMIT = "614be6d36f477349f766fb69a1bf9671e3241a58";

            OxyCommitParser.CheckUpdates(CURRENT_COMMIT);
        }
    }
}
