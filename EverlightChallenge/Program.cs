using EverlightChallenge.Factories;
namespace EverlightChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            int depth = 4;

            var logger = Factory.CreateLogger();
            var tree = Factory.CreateTree(depth);
            var application = Factory.CreateApplication(logger);

            application.Tree = tree;
            application.PredictResult();
            logger.Log($"Predicted Result : {application.PredictedResult}");
            application.RunBallsThrough();
            application.GetActualResult();
            logger.Log($"Actual Result : {application.ActualResult}");
        }
    }
}
