using System;

namespace PoissonDistribution1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Problem 2 : Find the cost of repair given mean and C= 160+ 40*x^2
            //Solution
            //double lambdaA = 0.88;
            //double lambdaB = 1.55;
            ////result A = 160 + 40(lambda+ lambda^2) because x^2 = lambda+lambda square
            //double resultA = 160 + 40 * (lambdaA + Math.Pow(lambdaA, 2));
            //double resultB = 128 + 40 * (lambdaB + Math.Pow(lambdaB, 2));
            //Console.WriteLine(resultA.ToString("0.000"));
            //Console.WriteLine(resultB.ToString("0.000"));


            double lambda = double.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            double result = PoissonDistribution(lambda,k);
            Console.WriteLine(result.ToString("0.000"));
        }

        private static double PoissonDistribution(double lambda, int k)
        {
            return (Math.Pow(lambda, k) * Math.Pow(Math.E, -lambda)) / Factorial(k);
        }

        private static double Factorial(int k)
        {
            if (k <= 0)
                return 1;
            else
            {
                return k*Factorial(k - 1);
            }
        }
    }
}
