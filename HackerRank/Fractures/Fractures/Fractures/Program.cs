using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Fractures
{
    class Program
    {
        static void plusMinus(int[] arr)
        {
            int n = arr.Length;
            int sumOfPositive = 0;
            int sumOfNegative = 0;
            int sumOfZeros = 0;
            foreach (int item in arr)
            {
                if (item > 0) { sumOfPositive += 1; Console.WriteLine("positives +1"); }
                else if (item == 0) { sumOfZeros += 1; Console.WriteLine("zeros +1"); }
                else if (item < 0) { sumOfNegative += 1; Console.WriteLine("Negatives +1"); }
            }
            decimal ratioOfPositive = (decimal)sumOfPositive / n;
            decimal ratioOfNegative = (decimal)sumOfNegative / n;
            decimal ratioOfZeros = (decimal)sumOfZeros / n;
            Console.WriteLine(ratioOfPositive);
            Console.WriteLine(ratioOfNegative);
            Console.WriteLine(ratioOfZeros);
        }
        static void Main(string[] args)
        {
            Random rng = new Random();
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = rng.Next(-10, 10);
                Console.Write(arr[i] + "\t");
            }
            plusMinus(arr);
        }
    }
}
