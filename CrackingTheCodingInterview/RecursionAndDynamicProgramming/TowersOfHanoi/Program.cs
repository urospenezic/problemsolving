using System;
using System.Collections.Generic;

namespace TowersOfHanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        // a classic solution to this problem, i had it as a homework in college. 
        // The idea is to move n-1 discs from A->B, then move the last one to C
        // after that move n-1 form B->A and move last one to C.
        // Do that recursively until C has all the disks.
        private static void Move(int discs, Stack<int> fromPeg, Stack<int> toPeg, Stack<int> otherPeg)
        {
        if (discs == 1)
        {
        toPeg.Push(fromPeg.Pop());
        return;
        }

        Move(discs - 1, fromPeg, otherPeg, toPeg);

        toPeg.Push(fromPeg.Pop());

        Move(discs -1, otherPeg, toPeg, fromPeg);
        }
    }
}
