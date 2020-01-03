using System;
using System.Numerics;

namespace ComputeFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            extraLongFactorials(n);
        }

        private static void extraLongFactorials(int n)
        {
            BigInteger smt = n;
            int m = n - 1;
            while (m!=0)
            {
                smt *= m;
                m--;
            }
            Console.WriteLine(smt);
        }
    }
}
