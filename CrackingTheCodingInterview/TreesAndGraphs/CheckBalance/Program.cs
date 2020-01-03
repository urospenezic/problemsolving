using System;
using BinarySearchTree;

namespace CheckBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            /*          5
                       / \
                      3   10
                     /  \   \
                    1    2   23
                        /      \
                       0        30
                                  \
                                   31   */
            var root = new BinaryTreeNode(5);
            root.AddInOrder(3);
            root.AddInOrder(1);
            root.AddInOrder(10);
            root.AddInOrder(23);
            root.AddInOrder(0);
            root.AddInOrder(30);
            root.AddInOrder(33);
            System.Console.WriteLine(CheckIfBalanced(root));
            
        }

        private static bool CheckIfBalanced(BinaryTreeNode root)
        {
            if(root==null)
            return true;
            int heightDifference = GetHight(root.Left) - GetHight(root.Right);
            if(Math.Abs(heightDifference)>1)
            return false;
            else
            return CheckIfBalanced(root.Left) && CheckIfBalanced(root.Right);
        }

        private static int GetHight(BinaryTreeNode node)
        {
            if(node==null)
            return -1;
            return Math.Max(GetHight(node.Left), GetHight(node.Right)) + 1;
        }
    }
}
