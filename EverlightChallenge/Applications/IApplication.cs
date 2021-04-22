using EverlightChallenge.DataStructures;

namespace EverlightChallenge.Applications
{
    public interface IApplication
    {
        ITree Tree { get; set; }
        int PredictedResult { get; }
        int ActualResult { get; }
        void PredictResult();
        void RunBallsThrough();
        void GetActualResult();

    }
}
