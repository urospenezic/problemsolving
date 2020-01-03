using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace DeleteMiddleNode
{
    class Program
    {
        // remove the non-first non-last element
        // of the single linked list
        // given only access to that element
        // C#s Next property is read-only, so a custom LinkedList needs to be implemented
        static void Main(string[] args)
        {
            var numberToBeDeleted= int.Parse(Console.ReadLine());
            var smt = new LinkedList();
            var input= Array.ConvertAll(Console.ReadLine().Split(" "),int.Parse);
            foreach (var number in input)
            {
                smt.AddToTail(number);
            }
            var nodeToDelete= GetNode(numberToBeDeleted,smt);
            RemoveNode(ref nodeToDelete);
            PrintList(smt);
        }

        private static void PrintList(LinkedList smt)
        {
            var current= smt.Head;
            while (current!=null)
            {

                Console.Write(current.Data + " ");
                current= current.Next;
            }
        }

        private static void RemoveNode(ref LinkedListNode nodeToDelete)
        {
            var next = nodeToDelete.Next;
            nodeToDelete.Data= next.Data;
            nodeToDelete.Next= next.Next;
            next.Next=null;
        }

        private static LinkedListNode GetNode(int numberToBeDeleted, LinkedList smt)
        {
            var current = smt.Head;
            while(current!=null)
            {
                var next= current.Next;
                if(current.Data==numberToBeDeleted)
                {
                    return current;
                }
                current=next;
            }
            return current;
        }
    }
}
