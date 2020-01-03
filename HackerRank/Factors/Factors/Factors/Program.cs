using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factors
{
    class Program
    {
        static int getTotalX(int[] a, int[] b)
        {
            List<int> factorsOfA = new List<int>();
            int bMin = b.Min();
            for (int i = bMin; i > 0; i--)
            {
                if (bMin % i == 0) factorsOfA.Add(i);
            }
            foreach(var item in factorsOfA.ToList())
            { 
                for (int j = 0; j < a.Length; j++)
                {
                    if (item % a[j] != 0)
                    {
                        factorsOfA.Remove(item);
                    }
                    if (factorsOfA.Count == 0) break;
                }
            }
            foreach(var item in factorsOfA.ToList())
            { 
                for (int j = 0; j < b.Length; j++)
                {
                    if (b[j] % item != 0)
                    {
                        factorsOfA.Remove(item);
                    }

                    if (factorsOfA.Count == 0) break;
                }
            }
            return factorsOfA.Count;

        }
        static void Main(string[] args)
        {
            //Random rng = new Random();
            //int n = int.Parse(Console.ReadLine());
            //int m = int.Parse(Console.ReadLine());
            //int[] A = new int[n];
            //int[] B = new int[m];
            //Console.WriteLine("Niz A:");
            //for (int i = 0; i < n; i++)
            //{
            //    A[i] = rng.Next(1, 100);
            //    Console.Write(A[i] + " ");
            //}
            //Console.WriteLine();
            //Console.WriteLine("Niz B:");
            //for (int i = 0; i < m; i++)
            //{
            //    B[i] = rng.Next(1, 100);
            //    Console.Write(B[i] + " ");
            //}
            int[] test1 = new int[] {2,4};
            int[] test2 = new int[] { 16,32,96};
            Console.WriteLine(getTotalX(test1, test2));
        }
    }
}
