using System;
using System.Collections.Generic;
using BinarySearchTree;

namespace ListOfDepths
{
    class Program
    {
        static void Main(string[] args)
        {
            //given a binary tree, design an algorithm which creates
            //a linked list of all the nodes at each depth
            var tree = new BinaryTreeNode(5);
            tree.AddInOrder(3);
            tree.AddInOrder(10);
            tree.AddInOrder(23);
            tree.AddInOrder(1);
            /* Tree:
                        5
                    3       10
                1     x  x      23   */
            var list = WriteLevelNodes(tree);
            PrintList(list);
            
        }

        private static void PrintList(LinkedList<int> list)
        {
            foreach (var item in list)
            {
                System.Console.WriteLine(item);
            }
        }

        private static LinkedList<int> WriteLevelNodes(BinaryTreeNode tree)
        {
            var list = new LinkedList<int>();
            var que = new Queue<BinaryTreeNode>();
            que.Enqueue(tree);
            while (que.Count>0)
            {
                var node = que.Dequeue();
                list.AddLast(node.Data);
                if(node.Left!=null)
                que.Enqueue(node.Left);
                if(node.Right!=null)
                que.Enqueue(node.Right);
            }
            return list;
        }
    }
}
