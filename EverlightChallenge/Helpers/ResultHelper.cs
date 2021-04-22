using EverlightChallenge.DataStructures;
using EverlightChallenge.Enums;

namespace EverlightChallenge.Helpers
{
    public class ResultHelper : IResultHelper
    {
        public INode PredictResult(ITree tree)
        {
            var predectedNode = FindPredictedResult(tree.RootNode);
            return predectedNode;
        }

        public INode GetActualResult(ITree tree)
        {
            var unfilledNode = FindUnfilledNode(tree.RootNode);
            return unfilledNode;
        }

        private INode FindUnfilledNode(INode node)
        {
            if (node.IsLeaf())
            {
                return node;
            }
            var unfilledNode = FindUnfilledNode(node.Left);
            if (unfilledNode.Filled == false)
                return unfilledNode;
            return FindUnfilledNode(node.Right);
        }

        private INode FindPredictedResult(INode node)
        {
            if (node.IsLeaf())
                return node;
            if (node.Switch == SwitchType.Left)
                return FindPredictedResult(node.Right);
            return FindPredictedResult(node.Left);
        }
    }
}
