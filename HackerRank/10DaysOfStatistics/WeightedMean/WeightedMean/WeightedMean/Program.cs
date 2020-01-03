using System;

namespace WeightedMean
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            var weights = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            WightedMean(n,arr,weights);
        }

        private static void WightedMean(int n, int[] arr, int[] weights)
        {
            int sumXW = 0;
            int sumW = 0;
            for (int i = 0; i < n; i++)
            {
                sumXW += arr[i] * weights[i];
                sumW += weights[i];
            }
            double result = Math.Round((double)sumXW / sumW, 1);
            Console.WriteLine(result.ToString("0.0"));
        }
    }
}
