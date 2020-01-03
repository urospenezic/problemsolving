using System;

namespace BinominalDistribution1
{
    class Program
    {
        static void Main(string[] args)
        {
            //double ratio = 1.09;

            //double p = ratio / (1 + ratio);
            double p = 0.12;
            int n = 10;
            double resultOne = 0;
            double resultTwo = 0;
            for (int x = 2; x <= n; x++)
            {
                resultOne += BinominalDistribution(p, x, n);
            }
            for (int i = 0; i <=2; i++)
            {
                resultTwo += BinominalDistribution(p, i, n);
            }
            Console.WriteLine(resultTwo.ToString("0.000"));
            Console.WriteLine(resultOne.ToString("0.000"));

        }
        public static double BinominalDistribution(double p, int x, int n)
        {
            return Combinations(x, n) * Math.Pow(p, x) * Math.Pow(1 - p, n-x);
        }
        public static double Combinations(int x, int n)
        {
            return Factorial(n) / (Factorial(x) * Factorial(n - x));
        }
        public static long Factorial(int x)
        {
            if (x <= 0)
                return 1;
            else
            {
                return x * Factorial(x - 1);
            }
        }
    }
}
