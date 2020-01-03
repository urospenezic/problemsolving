using System;
using System.Linq;

namespace Quartiles
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            Array.Sort(arr);
            GetQuartiles(arr,n);
        }

        private static void GetQuartiles(int[] arr, int n)
        {
            double q1 = 0, q2 = 0, q3 = 0;
            int[] firstArray = arr.Take(arr.Length / 2).ToArray();
            q1 = Median(firstArray);
            if (n%2!=0)
            {
                int[] secondArray = arr.Skip(arr.Length / 2 + 1).ToArray();
                q2 = arr[n / 2];
                q3 = Median(secondArray);
            }
            else
            {
                int[] secondArray = arr.Skip(arr.Length / 2).ToArray();
                q2 = Math.Round((double)(arr[n / 2] + arr[n / 2 - 1]) / 2, 1);
                q3 = Median(secondArray);
            }
            Console.WriteLine($"{q1}\n{q2}\n{q3}\n");
        }
        private static double Median(int[]arr)
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
