using System;
namespace EverlightChallenge.DataStructures
{
    public class Tree : ITree
    {
        private int _maxDepth;
        private int _leafNodeIndex = 1;
        private INode _rootNode;

        public int Depth { get { return _maxDepth; } }
        public INode RootNode { get { return _rootNode; } }

        public Tree(int maxDepth)
        {
            if (maxDepth <= 0)
                throw new Exception("Depth of tree must be greater than 0");
            _maxDepth = maxDepth;

            Initialize();
        }

        private void Initialize()
        {
            _rootNode = new Node(0);
            BuildTree(_rootNode);
        }

        private void BuildTree(INode node)
        {
            if (node.Depth < _maxDepth)
            {
                if (node.Left == null)
                    node.Left = new Node(node.Depth + 1);
                if (node.Right == null)
                    node.Right = new Node(node.Depth + 1);
                BuildTree(node.Left);
                BuildTree(node.Right);
            }
            else
            {
                node.Index = _leafNodeIndex++;
            }
        }
    }
}
