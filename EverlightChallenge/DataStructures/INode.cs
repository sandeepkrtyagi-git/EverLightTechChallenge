using EverlightChallenge.Enums;

namespace EverlightChallenge.DataStructures
{
    public interface INode
    {
        int Data { get; set; }
        int Depth { get; }
        INode Left { get; set; }
        INode Right { get; set; }
        SwitchType Switch { get; set; }
        public int Index { get; set; }
        public bool Filled { get; set; }

        void FlipSwitch();
        bool IsLeaf();
    }
}