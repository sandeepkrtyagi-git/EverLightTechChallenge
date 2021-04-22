using System;
using EverlightChallenge.Enums;

namespace EverlightChallenge.DataStructures
{
    public class Node : INode
    {
        //public NodeValue Value { get; set; }
        public int Data { get; set; }
        public INode Left { get; set; }
        public INode Right { get; set; }
        public int Depth { get; }
        public SwitchType Switch { get; set; }
        public bool Filled { get; set; }
        public int Index { get; set; }

        public Node(int depth)
        {
            Depth = depth;
            this.Switch = new Random().Next(2) == 0 ? SwitchType.Left : SwitchType.Right;
        }
        public bool IsLeaf()
        {
            return (Left == null) && (Right == null);
        }

        public void FlipSwitch()
        {
            this.Switch = Switch == SwitchType.Left ? SwitchType.Right : SwitchType.Left;
        }
    }
}
