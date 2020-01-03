using System;
using BinarySearchTree;

namespace CheckIfBST
{
    class Program
    {
        // write an algorithm to check if a given binary search tree 
        // is a binary search tree
        static void Main(string[] args)
        {
            var root = new BinaryTreeNode(5);
            var current = new Current();
            root.AddInOrder(3);
            root.AddInOrder(1);
            root.AddInOrder(10);
            root.AddInOrder(23);
            root.AddInOrder(0);
            Console.WriteLine(CheckIfBinarySearchTree(root, current));
        }

        private static bool CheckIfBinarySearchTree(BinaryTreeNode root, Current current)
        {
            if(root!=null)
            {
            CheckIfBinarySearchTree(root.Left, current);
            if(root.Data>=current.CurrentMin)
            {
                current.CurrentMin = root.Data;
            }
            else 
            return false;
            CheckIfBinarySearchTree(root.Right,current);
            }
            return true;
        }
        internal class Current
        {
            public int CurrentMin { get; set; } = int.MinValue;
        }
    }
}
