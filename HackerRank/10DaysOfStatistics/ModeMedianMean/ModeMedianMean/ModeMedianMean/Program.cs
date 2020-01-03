using System;
using System.Collections.Generic;
using System.Linq;
namespace ModeMedianMean
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var arr = Array.ConvertAll(Console.ReadLine().Split(' '),int.Parse);
            Mean(arr,n);
            Median(arr,n);
            Mode(arr, n);
        }

        private static void Mode(int[] arr, int n)
        {
            var frequencyTable = new SortedDictionary<int, int>();
            for (int i = 0; i < n; i++)
            {
                if (frequencyTable.ContainsKey(arr[i]))
                    frequencyTable[arr[i]]++;
                else
                    frequencyTable.Add(arr[i], 1);
            }
            int max= frequencyTable.Values.Max();
            var result= frequencyTable.FirstOrDefault(kp => kp.Value == max).Key;
            Console.WriteLine(result);
            
        }

        private static void Median(int[] arr, int n)
        {
            Array.Sort(arr);
            if (n % 2 != 0)
                Console.WriteLine(arr[n / 2]);
            else
            {
                double result = Math.Round((double)(arr[n / 2] + arr[n / 2 - 1]) / 2,1);
                Console.WriteLine(result);
            }
        }

        private static void Mean(int[] arr, int n)
        {
            int sum = 0;
            foreach (var item in arr)
            {
                sum += item;
            }
            double result = Math.Round((double)sum / n, 1);
            Console.WriteLine(result);
        }
    }
}
