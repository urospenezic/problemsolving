using System;
using BinarySearchTree;

namespace Successor
{
    class Program
    {
        // Write an algorithm to find the "next" node (in-order successor)
        // of a given node in a binary search tree. Nodes have link to parents.
        static void Main(string[] args)
        {
            var root = new BinaryTreeNode(8);
            Populate(root);
            var node = root.Find(20);
            System.Console.WriteLine(FindSuccessor(node).Data);
        }

        private static void Populate(BinaryTreeNode root)
        {
            root.AddInOrder(4);
            root.AddInOrder(2);
            root.AddInOrder(6);
            root.AddInOrder(10);
            root.AddInOrder(20);
        }

        public static BinaryTreeNode FindSuccessor(BinaryTreeNode node)
        {
            if(node.Parent==null)
            return node.Right;
            else if(node.Parent.Left == node && node.Right==null)
            return node.Parent;
            else
            return InorderTraversal(node.Right) == null ? new BinaryTreeNode(-1) : node;
        }
        public static BinaryTreeNode InorderTraversal(BinaryTreeNode node)
        {
            if(node!=null)
            {
                InorderTraversal(node.Left);
                return node;
            }
            return null;
        }
    }
}
