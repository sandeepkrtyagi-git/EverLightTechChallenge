using EverlightChallenge.DataStructures;

namespace EverlightChallenge.Helpers
{
    public interface IResultHelper
    {
        INode PredictResult(ITree tree);
        INode GetActualResult(ITree tree);
    }
}