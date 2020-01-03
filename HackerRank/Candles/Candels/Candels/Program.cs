using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candels
{
    class Program
    {
        static int birthdayCakeCandles(int[] ar)
        {
            int sum = 0;
            int max = ar.Max();
            Console.WriteLine($"Max je: {max}");
            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] == max) sum += 1;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Random rng = new Random();
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = rng.Next(1, 5);
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine(birthdayCakeCandles(arr));
            
        }
    }
}
