using EverlightChallenge.DataStructures;
using EverlightChallenge.Helpers;
using EverlightChallenge.Utilities;

namespace EverlightChallenge.Applications
{
    public class Application : IApplication
    {
        private int _predectedResult;
        private ILogger _logger;
        private IResultHelper _resultHelper;
        private IBallRunner _ballRunner;
        private int _actualResult;

        public int PredictedResult { get {return _predectedResult; } }
        public int ActualResult { get { return _actualResult; } }
        public ITree Tree { get; set; }
        
        public Application(ILogger logger, IBallRunner ballRunner, IResultHelper resultHelper)
        {
            _logger = logger;
            _ballRunner = ballRunner;
            _resultHelper = resultHelper;
        }

        public void PredictResult()
        {
            var predectedNode = _resultHelper.PredictResult(this.Tree);
            _predectedResult = predectedNode.Index;
        }

        public void RunBallsThrough()
        {
            _logger.Log("Running balls process started...");

            _ballRunner.RunBalls(this.Tree);

            _logger.Log("Running balls process finished...");
        }
        public void GetActualResult()
        {
            var unfilledNode = _resultHelper.GetActualResult(this.Tree);
            _actualResult = unfilledNode.Index;
        }
    }
}
