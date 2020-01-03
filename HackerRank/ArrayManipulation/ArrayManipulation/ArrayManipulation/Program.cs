using System;
using System.Linq;

namespace ArrayManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nm = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nm[0]);

            int m = Convert.ToInt32(nm[1]);

            int[][] queries = new int[m][];

            for (int i = 0; i < m; i++)
            {
                queries[i] = Array.ConvertAll(Console.ReadLine().Split(' '), queriesTemp => Convert.ToInt32(queriesTemp));
            }

            long result = arrayManipulation(n, queries);
            Console.WriteLine(result);
        }

        private static long arrayManipulation(int n, int[][] queries)
        {
            long[] arrayOfZeros = GenerateArray(n);
            for (int i = 0; i < queries.GetLength(0); i++)
            {
                for (int j = queries[i][0] -1; j <= queries[i][1]-1; j++)
                {
                    arrayOfZeros[j] += queries[i][2];
                }
            }
            return arrayOfZeros.Max();
        }

        private static long[] GenerateArray(int n)
        {
            long[] arrayOfZeros = new long[n];
            for (int i = 0; i < n; i++)
            {
                arrayOfZeros[i] = 0;
            }
            return arrayOfZeros;
        }
    }
}
