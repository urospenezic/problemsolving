using System;

namespace LeftRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nd = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nd[0]);

            int d = Convert.ToInt32(nd[1]);

            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
            ;
            int[] result = rotLeft(a, d);
            foreach (var number in result)
            {
                Console.Write(number + " ");
            }
        }
        /// <summary>
        /// example
        /// 0 5 6 4
        /// </summary>
        /// <param name="a"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        private static int[] rotLeft(int[] a, int d)
        {
            int[] b = new int[a.Length];
            if (a.Length < 2)
                return a;
            for (int j = 0; j < a.Length; j++)
            {
                int position = (j+(a.Length - d)) % a.Length;
                b[position] = a[j];
            }
            return b;
        }
    }
}
