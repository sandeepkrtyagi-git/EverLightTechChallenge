using EverlightChallenge.Applications;
using EverlightChallenge.DataStructures;
using EverlightChallenge.Helpers;
using EverlightChallenge.Utilities;

namespace EverlightChallenge.Factories
{
    public class Factory
    {
        public static ILogger CreateLogger()
        {
            return new Logger();
        }

        public static IBallRunner CreateBallRunner()
        {
            return new BallRunner();
        }

        public static IResultHelper CreateResultHelper()
        {
            return new ResultHelper();
        }

        public static ITree CreateTree(int depth)
        {
            return new Tree(depth);
        }

        public static IApplication CreateApplication(ILogger logger)
        {
            return new Application(logger, CreateBallRunner(), CreateResultHelper());
        }
    }
}
