using System;
using System.Linq;

namespace StandardDeviation
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            CalculateStDev(arr);
        }

        private static void CalculateStDev(int[] arr)
        {
            var values = arr.ToList();
            double result = 0;
            if (arr.Count() > 0)
            {
                double avg = values.Average();
                double sum = values.Sum(d => Math.Pow(d - avg, 2));
                result = Math.Sqrt((sum) / values.Count());
            }
            Console.WriteLine(result.ToString("0.0"));
        }
    }
}
