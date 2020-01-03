using System;

namespace FactorialRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            int n= Factorial(3);
            Console.WriteLine(n);
        }

        private static int Factorial(int v)
        {
            if (v <= 1)
                return 1;
            else
            {
                return v * Factorial(v - 1);
            }
        }
    }
}
