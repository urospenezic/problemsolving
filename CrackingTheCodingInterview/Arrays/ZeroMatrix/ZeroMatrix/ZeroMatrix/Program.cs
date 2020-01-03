using System;

namespace ZeroMatrix
{
    class Program
    {
        /// <summary>
        /// Given a MxN matrix
        /// write an algorithm such as if one cell is 0
        /// its entire row and column are set to 0
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int[][] arr = new int[m][];
            for (int i = 0; i < n; i++)
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(" "), c => int.Parse(c));
            }
            Console.WriteLine();
            ZeroMatrix(arr);
            Console.WriteLine();
        }

        private static void ZeroMatrix(int[][] arr)
        {
            // 1 2 0 3 1
            // 2 5 6 7 1
            // 3 0 2 3 1
            // 1 1 1 1 1
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    if (arr[i][j] == 0)
                    {
                        arr[0][j] = 0;
                        arr[i][0] = 0;
                    }
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i][0] == 0)
                    NullRow(ref arr, i);
            }
            for (int i = 0; i < arr[0].Length; i++)
            {
                if (arr[0][i] == 0)
                    NullColumn(ref arr, i);
            }
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

        private static void NullColumn(ref int[][] arr, int i)
        {
            for (int j = 0; j < arr.Length; j++)
            {
                arr[j][i] = 0;
            }
        }

        private static void NullRow(ref int[][] arr, int i)
        {
            for (int j = 0; j < arr[i].Length; j++)
            {
                arr[i][j] = 0;
            }
        }
    }
}
