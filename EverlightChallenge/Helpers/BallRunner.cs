using System;
using EverlightChallenge.DataStructures;
using EverlightChallenge.Enums;

namespace EverlightChallenge.Helpers
{
    public class BallRunner : IBallRunner
    {
        public void RunBalls(ITree tree)
        {
            var leafCount = (int)Math.Pow(2, tree.Depth);
            for (var index = 0; index < leafCount - 1; index++)
            {
                RunBallsThrough(tree.RootNode);
            }
        }
        private void RunBallsThrough(INode node)
        {
            if (node.IsLeaf())
            {
                node.Filled = true;
                return;
            }
            if (node.Switch == SwitchType.Left)
            {
                node.FlipSwitch();
                RunBallsThrough(node.Left);
            }
            else
            {
                node.FlipSwitch();
                RunBallsThrough(node.Right);
            }
        }
    }
}
