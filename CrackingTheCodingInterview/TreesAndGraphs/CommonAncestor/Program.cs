using System;
using BinarySearchTree;

namespace CommonAncestor
{
    class Program
    {
        static void Main(string[] args)
        {
            var tree = new BinaryTreeNode(5);
            Populate(tree);
            var firstNode = tree.Find(28);
            var secondNode = tree.Find(11);
            Console.WriteLine(FindCommonAncestor(firstNode, secondNode).Data);
            
        }

        private static BinaryTreeNode FindCommonAncestor(BinaryTreeNode firstNode, BinaryTreeNode secondNode)
        {
            var depthOne = GetDepth(firstNode);
            var depthTwo = GetDepth(secondNode);
            var offset = depthOne - depthTwo;
            var deeperNode = offset > 0 ? firstNode : secondNode;
            var shallowNode = offset > 0 ? secondNode : firstNode;
            deeperNode = PopUpToEqualize(deeperNode, Math.Abs(offset));
            while (deeperNode.Data!=shallowNode.Data && shallowNode!=null && deeperNode!=null)
            {
                deeperNode = deeperNode.Parent;
                shallowNode = shallowNode.Parent;
            }
            return deeperNode;
        }

        private static BinaryTreeNode PopUpToEqualize(BinaryTreeNode deeperNode, int offset)
        {
            while (offset>0 && deeperNode!=null)
            {
                deeperNode = deeperNode.Parent;
                offset--;
            }
            return deeperNode;
        }

        public static int GetDepth(BinaryTreeNode node)
        {
            int depth = 0;
            while (node!=null)
            {
                depth++;
                node = node.Parent;
            }
            return depth;
        }
        private static void Populate(BinaryTreeNode tree)
        {
            tree.AddInOrder(3);
            tree.AddInOrder(2);
            tree.AddInOrder(10);
            tree.AddInOrder(13);
            tree.AddInOrder(20);
            tree.AddInOrder(1);
            tree.AddInOrder(11);
            tree.AddInOrder(32);
            tree.AddInOrder(28);
        }
        /*    5
            2   3
          1       10
                     13
                  11    20
                          32
                        28  */
    }
}
