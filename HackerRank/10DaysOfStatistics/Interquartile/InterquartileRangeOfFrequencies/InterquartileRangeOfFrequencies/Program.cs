using System;
using System.Collections.Generic;
using System.Linq;

namespace Quartiles
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            var fq= Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            var set = new List<int>();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < fq[i]; j++)
                {
                    set.Add(arr[i]);
                }
            }
            set.Sort();
            GetQuartiles(set, n);
        }

        private static void GetQuartiles(List<int> arr, int n)
        {
            double q1 = 0, q2 = 0, q3 = 0;
            int[] firstArray = arr.Take(arr.Count / 2).ToArray();
            q1 = Median(firstArray);
            if (n % 2 != 0)
            {
                int[] secondArray = arr.Skip(arr.Count / 2 + 1).ToArray();
                q2 = arr[n / 2];
                q3 = Median(secondArray);
            }
            else
            {
                int[] secondArray = arr.Skip(arr.Count / 2).ToArray();
                q2 = Math.Round((double)(arr[n / 2] + arr[n / 2 - 1]) / 2, 1);
                q3 = Median(secondArray);
            }
            Console.WriteLine((q3-q1).ToString("0.0"));
        }
        private static double Median(int[] arr)
        {
            double q = 0;
            if (arr.Length % 2 != 0)
            {
                q = arr[arr.Length / 2];
            }
            else
            {
                q = Math.Round((double)(arr[arr.Length / 2] + arr[arr.Length / 2 - 1]) / 2, 1);
            }
            return q;
        }
    }
}
