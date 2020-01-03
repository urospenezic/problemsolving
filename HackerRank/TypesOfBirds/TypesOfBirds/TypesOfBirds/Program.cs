using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesOfBirds
{
    class Program
    {
        static int migratoryBirds(List<int> arr)
        {
            int[] type1 = new int[] { 0, 1 };
            int[] type2 = new int[] { 0, 2 };
            int[] type3 = new int[] { 0, 3 };
            int[] type4 = new int[] { 0, 4 };
            int[] type5 = new int[] { 0, 5 };
            foreach (var bird in arr)
            {
                switch (bird)
                {
                    case 1:
                        type1[0]++;
                        break;
                    case 2:
                        type2[0]++;
                        break;
                    case 3:
                        type3[0]++;
                        break;
                    case 4:
                        type4[0]++;
                        break;
                    case 5:
                        type5[0]++;
                        break;
                }
            }
            int[][] result = new int[][] { type1, type2, type3, type4, type5 };
            int max = result[0][0];
            for (int i = 1; i < result.Length; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (result[i][0] > max) max = result[i][0];
                }
            }
            int rezultat = 0;
            for (int i = 0; i < result.Length; i++)
            {
                    if (result[i][0] == max)
                    {
                        rezultat = result[i][1];
                    break;
                    }
            }
            return rezultat;
        }
        static void Main(string[] args)
        {
            Random rng = new Random();
            List<int> arr = new List<int>();
            Console.WriteLine("N:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                arr.Add(rng.Next(1,5));
                Console.Write(arr[i] + " ");
            }
            int kucaj = migratoryBirds(arr);
            Console.WriteLine();
            Console.WriteLine(string.Join(" ", kucaj));
            Console.WriteLine();
        }
    }
}
