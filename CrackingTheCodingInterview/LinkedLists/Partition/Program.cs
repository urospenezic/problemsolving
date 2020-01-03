using System;
using DeleteMiddleNode;

namespace Partition
{
    // Partition a linked list around a value 'x', such that all nodes less than x come before all nodes greater than or equal to x.
    // If 'x' is contained in the list, we need lesser number on the left side and greater on the right side in any given order.
    class Program
    {
        static void Main(string[] args)
        {
            var smt = new LinkedList();
            var input= Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            var x = int.Parse(Console.ReadLine());
            foreach (var number in input)
            {
                smt.AddToTail(number);
            }
            var node = PartitionGivenList(x,smt);
            PrintLinkedList(node);
        }

        private static void PrintLinkedList(LinkedListNode node)
        {;
            while (node!=null)
            {
                Console.Write(node.Data + " ");
                node= node.Next;
            }
        }
            // Create 2 linked lists from the existing one and merge them together
        private static LinkedListNode PartitionGivenList(int x, LinkedList smt)
        {
            var listAfter= new LinkedList();
            var listBefore= new LinkedList();
            var current = smt.Head;
            while (current!=null)
            {
                var next = current.Next;
                current.Next=null;
                if(current.Data<x)
                {
                    listBefore.AddToTail(current.Data);
                }
                else
                {
                    listAfter.AddToTail(current.Data);
                }
                current= next;
            }
            if(listAfter.Head==null)
            return listBefore.Head;
            else if(listBefore.Head==null)
            {
                return listAfter.Head;
            }
            //merge
            var lastNodeOfLeftSideList = GetLastNode(listBefore);
            lastNodeOfLeftSideList.Next= listAfter.Head;
            return listBefore.Head;
        }
        private static LinkedListNode GetLastNode(LinkedList smt)
        {
            var current = smt.Head;
            while (current!=null)
            {
                var next = current.Next;
                if(next==null)
                return current;
                current=next;
            }
            
            return smt.Head;
        }
    }
}
