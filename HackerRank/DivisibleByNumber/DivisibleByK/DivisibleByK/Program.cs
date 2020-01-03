using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisibleByK
{
    class Program
    {
        static int divisibleSumPairs(int n, int k, int[] ar)
        {
            int divider = 0;
            int count = 0;
            for (int i = 0; i < n-1; i++)
            {
                for (int j = i+1; j < n; j++)
                {
                    divider = ar[i] + ar[j];
                    if (divider % k == 0) count++;
                    divider = 0;
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            Random rng = new Random();
            Console.WriteLine("N:");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = rng.Next(0, 10);
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("K");
            int k = int.Parse(Console.ReadLine());
        }
    }
}
