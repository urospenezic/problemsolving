using System;
using System.IO;

namespace NumberOfClouds
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine());

            int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp))
            ;
            int result = jumpingOnClouds(c);
            Console.WriteLine(result);
        }
        // Example c= [0 0 0 1 0 0]
        // example 0 0 0 0 0
        private static int jumpingOnClouds(int[] c)
        {
            int n = c.Length;
            var numberOfStepps = 0;
            for (int i = 0; i < n; i++)
            {
                if(n<2 || i==n-1)
                {
                    return numberOfStepps;
                }
                if (i < n - 2 && c[i + 2] == 0)
                {
                    i = i + 1;
                    numberOfStepps++;
                }
                else
                {
                    numberOfStepps++;
                }
            }
            return numberOfStepps;
        }
    }
}
