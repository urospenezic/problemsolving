using System;

namespace SherlockAndSquares
{
    class Program
    {
        static void Main(string[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string[] ab = Console.ReadLine().Split(' ');

                int a = Convert.ToInt32(ab[0]);

                int b = Convert.ToInt32(ab[1]);

                int result = squares(a, b);
                Console.WriteLine(result);
            }
        }
        /// <summary>
        /// example:
        /// 24 27
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        private static int squares(int a, int b)
        {
            
            int sum = Convert.ToInt32(Math.Floor(Math.Sqrt(b))-Math.Ceiling(Math.Sqrt(a))+1);
            
            return sum;
        }
    }
}
