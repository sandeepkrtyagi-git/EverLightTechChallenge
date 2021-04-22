namespace EverlightChallenge.DataStructures
{
    public interface ITree
    {
        int Depth { get; }
        INode RootNode { get; }
    }
}