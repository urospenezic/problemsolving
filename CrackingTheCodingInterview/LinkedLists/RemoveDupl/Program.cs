using System;
using System.Collections.Generic;

namespace RemoveDupl
{
    // Remove duplicates from a linked list
    class Program
    {
        static void Main(string[] args)
        {
            var smt = new LinkedList<int>();
            var input = Array.ConvertAll(Console.ReadLine().Split(" "),int.Parse);
            foreach (var number in input)
            {
                smt.AddLast(number);
            }
            foreach (var item in RemoveDuplicates(smt))
            {
                Console.Write(item + " ");
            }
        }

        private static LinkedList<int> RemoveDuplicates(LinkedList<int> smt)
        {
            var buffer = new List<int>();
            var current = smt.First;
            while (current!=null)
            {
                var next = current.Next;
                if(!buffer.Contains(current.Value))
                buffer.Add(current.Value);
                else
                smt.Remove(current);
                current=next;
            }
            return smt;
        }
    }
}
