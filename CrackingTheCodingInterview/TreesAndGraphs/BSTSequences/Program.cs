using System;
using BinarySearchTree;

namespace BSTSequences
{
    class Program
    {
        static void Main(string[] args)
        {
            var tree = new BinaryTreeNode(2);
            Populate(tree);
            
        }

        private static void Populate(BinaryTreeNode tree)
        {
            tree.AddInOrder(3);
            tree.AddInOrder(1);
            tree.AddInOrder(4);
            tree.AddInOrder(5);
            tree.AddInOrder(10);
            tree.AddInOrder(11);
            tree.AddInOrder(6);
        }
    }
}
