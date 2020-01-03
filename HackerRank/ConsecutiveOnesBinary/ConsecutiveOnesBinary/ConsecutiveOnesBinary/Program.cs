using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsecutiveOnesBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int numberOfOnes = NumberOfOnes(n);
            Console.WriteLine(numberOfOnes);
        }

        private static int NumberOfOnes(int n)
        {
            var listOfAllConsecutiveOnes = new List<int>();
            int remainder = 0;
            int numberOfOnes = 0;
            while (n!=0)
            {
                remainder = n % 2;
                if (remainder == 1)
                    numberOfOnes++;
                else
                {
                    listOfAllConsecutiveOnes.Add(numberOfOnes);
                    numberOfOnes = 0;
                }
                n = n / 2;
                if (n == 0)
                    listOfAllConsecutiveOnes.Add(numberOfOnes);
            }
            return listOfAllConsecutiveOnes.Max();
        }
    }
}
