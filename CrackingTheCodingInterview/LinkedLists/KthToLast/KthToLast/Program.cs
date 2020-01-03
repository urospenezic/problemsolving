using System;
using System.Collections.Generic;

namespace KthToLast
{
    class Program
    {
        static void Main(string[] args)
        {
            var smt = new LinkedList<int>();
            int n= int.Parse(Console.ReadLine());
            var input = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            foreach (var number in input)
            {
                smt.AddLast(number);
            }
            Console.WriteLine(ReturnKthToLastElement(smt,n).ToString());
        }
        //second approach without c#s Count property
        // would be to have 2 iterators p1 and p2
        //  we move p1 till k first
        //   then we move p2 and p1 simultaniously
        //    when p1 hits the end, we got kth element
        private static int ReturnKthToLastElement(LinkedList<int> smt, int n)
        {
            int offset= 0;
            var current = smt.First;
            while(current!=null)
            {
                var next = current.Next;
                if(offset + n==smt.Count)
                return current.Value;
                offset++;
                current = next;
            }
            return -1;
        }
    }
}
