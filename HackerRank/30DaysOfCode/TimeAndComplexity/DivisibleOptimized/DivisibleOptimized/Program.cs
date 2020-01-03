using System;

namespace DivisibleOptimized
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine(IsItAPrimeNumber(number));
            }
        }

        private static string IsItAPrimeNumber(int number)
        {
            for (int i = 2; i*i <= number; i++)
            {
                if (number % i == 0)
                    return "NOT PRIME";
            }
            return "PRIME";
        }
    }
}
