using System;

namespace BeautifulDay
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ijk = Console.ReadLine().Split(' ');

            int i = Convert.ToInt32(ijk[0]);

            int j = Convert.ToInt32(ijk[1]);

            int k = Convert.ToInt32(ijk[2]);

            int result = beautifulDays(i, j, k);
            Console.WriteLine(result);
        }

        private static int beautifulDays(int i, int j, int k)
        {
            int numberOfBeautifulDays = 0;
            for (int m = i; m < j + 1; m++)
            {
                int reversed = reverse(m);
                if ((m - reversed) % k == 0)
                    numberOfBeautifulDays++;
            }
            return numberOfBeautifulDays;
        }

        private static int reverse(int m)
        {
            int reverse=0;
            int remainder;
            while (m != 0)
            {
                remainder = m % 10;
                reverse = reverse * 10 + remainder;
                m /= 10;
            }
            return reverse;
        }
    }
}
