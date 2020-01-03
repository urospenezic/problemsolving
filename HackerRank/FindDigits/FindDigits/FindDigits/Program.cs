using System;

namespace FindDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                int result = findDigits(n);
                Console.WriteLine(result);
            }
        }

        private static int findDigits(int n)
        {
            // 
            int remainder = 0;
            int m = n;
            int smt = 0;
            while (m!=0)
            {
                remainder = m % 10;
                if (remainder!=0 && n % remainder == 0)
                    smt++;
                m = m / 10;
            }
            return smt;
        }
    }
}
