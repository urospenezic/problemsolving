using System;
using System.Collections.Generic;
using System.Linq;
namespace Sums
{
    /// given 2 linked lists representing number
    //  (each node containing 1 digit)
    //  write an algorithm to return a new list
    //  containing digits of a number
    //  representing the sum of 2 lists
    //  the digits are in reverse order. 2->1 + 1->3 
    //                                is the same as 12 + 31
    class Program
    {
        static void Main(string[] args)
        {
            var numberOne= new LinkedList<int>();
            var numberTwo= new LinkedList<int>();
            var inputOne = Array.ConvertAll(Console.ReadLine().Split(" "),int.Parse).ToList();
            var inputTwo = Array.ConvertAll(Console.ReadLine().Split(" "),int.Parse);
            foreach (var item in inputOne)
            {
                numberOne.AddLast(item);
            }
            foreach (var item in inputTwo)
            {
                numberTwo.AddLast(item);
            }
            var result = SumGivenNumbers(numberOne, numberTwo);
            foreach (var item in result)
            {
                Console.Write(item);
            }
        }
        // NON RECURSIVE:
        // recursive would funcion pretty much the same, you would just pass the nodes
        // ofc without while loop (that part would be recursive)
        // personally i dont like that recursion because you would have
        // to pass null values as params at some point
        // so the solution is equaly terrible
        private static LinkedList<int> SumGivenNumbers(LinkedList<int> numberOne, LinkedList<int> numberTwo)
        {
            var result = new LinkedList<int>();
            var currentOne= numberOne.First;
            var currentTwo= numberTwo.First;
            int placeHolder=0;
            int sum= 0;
            while (currentOne!=null || currentTwo!=null)
            {
                sum = 0;
                if(currentOne!=null)
                sum += currentOne.Value;
                if(currentTwo!=null)
                sum+= currentTwo.Value;
                sum+=placeHolder;
                result.AddLast(sum%10 );
                placeHolder= sum/10;
                if(currentOne!=null)
                currentOne = currentOne.Next;
                if(currentTwo!=null)
                currentTwo= currentTwo.Next;
            }
            if(placeHolder!=0)
            result.AddLast(placeHolder);
            return result;
        }
    }
}