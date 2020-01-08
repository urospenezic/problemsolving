using System;

namespace RotateMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] arr = new int[n][];
            for (int i = 0; i < n; i++)
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(" "), c=>int.Parse(c));
            }
            Console.WriteLine();
            RotateMatrix(arr);
        }
        /// <summary>
        /// MOST OPTIMAL ROTATION
        /// </summary>
        /// <param name="arr"></param>
        private static void RotateMatrix(int[][] arr)
        {
            /*
             * 1 2 3 4
             * 1 2 3 4
             * 1 2 3 4
             * 1 2 3 4 
            */
            int n = arr.GetLength(0);
            for (int layer = 0; layer < n/2; layer++)
            {
                int first = layer;
                int last = n - 1 - layer;
                for (int i = first; i < last; i++)
                {
                    int offset = i - first;
                    int top = arr[first][i];
                    arr[first][i] = arr[last - offset][first];
                    arr[last - offset][first] = arr[last][last - offset];
                    arr[last][last - offset] = arr[i][last];
                    arr[i][last] = top;
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
