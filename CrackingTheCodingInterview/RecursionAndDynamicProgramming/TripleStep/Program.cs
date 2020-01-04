using System;
using System.Linq;

namespace TripleStep
{
    // A child is running up the stairs. Write an algorithm to find the number of combinations a child can climb the stairs
    // if he can jump 1, 2 and 3 stepps at a time.
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfSteps = int.Parse(Console.ReadLine());
            int n = ComputePossibleCombinations(numberOfSteps);
            System.Console.WriteLine($"The possible combinations a child can take to get to N is: {n}");
        }
        private static int ComputePossibleCombinations(int numberOfSteps)
        {
            int[] memo = new int[numberOfSteps + 1];
            Array.Fill(memo,-1);
            return GetCombination(numberOfSteps, memo);
        }
        private static int GetCombination(int numberOfSteps, int[] memo)
        {
            if(numberOfSteps < 0) return 0;
            else if(numberOfSteps==0) return 1;
            else if(memo[numberOfSteps] > 1) return memo[numberOfSteps];
            else
            {
                memo[numberOfSteps] = GetCombination(numberOfSteps-1, memo) + GetCombination(numberOfSteps -2, memo) + GetCombination(numberOfSteps - 3, memo);
            }
            return memo[numberOfSteps];
        }
    }
}
