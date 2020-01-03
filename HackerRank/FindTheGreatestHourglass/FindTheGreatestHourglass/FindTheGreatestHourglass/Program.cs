using System;

namespace FindTheGreatestHourglass
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[6][];

            for (int i = 0; i < 6; i++)
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }

            int result = hourglassSum(arr);
            Console.WriteLine(result);
        }
        /// <summary>
        /// Example:
        /// -9 0 8 7 6 4
        ///  1 3 5 4 4 6
        ///  2 5 6 9 2 8
        ///  3 6 5 8 4 1
        ///  6 5 4 8 2 1
        ///  1 1 1 1 1 1
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        private static int hourglassSum(int[][] arr)
        {
            int row = 0;
            int maxSum = int.MinValue;
            for (int i = 0; i < 4; i++)
            {
                int currentSum = 0;
                for (int j = row; j < row + 3; j++)
                {
                    if (j == row + 1)
                        currentSum += arr[j][i + 1];
                    else currentSum += (arr[j][i] + arr[j][i + 1] + arr[j][i + 2]);
                }
                if (currentSum > maxSum) maxSum = currentSum;
                if (i == arr.Length / 2)
                {
                    if (row == arr.Length / 2)
                    {
                        return maxSum;
                    }
                    i = -1;
                    row++;
                }
            }
            return 0;
        }
    }
}
