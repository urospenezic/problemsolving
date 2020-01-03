using System;

namespace MinimumSwaps
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            ;
            int res = minimumSwaps(arr);
            Console.WriteLine(res);
        }
        /// <summary>
        /// example
        /// [7, 1, 3, 2, 4, 5, 6]
        /// ako dodam pomocni niz pozicija
        /// [1, 2, 3, 4, 5, 6 ,7]
        /// onda mogu da ih presvucem po poziciji
        /// gde uzimam nulti i smestam gde treba da bude
        /// ako je tu, idem dalje dok ne dodjem do n-1
        /// 
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        private static int minimumSwaps(int[] arr)
        {
            int[] arrayOfPositions = GenerateHelpArray(arr);
            int swaps = 0;
            int i = 0;
            if (arr.Length<2)
            {
                return 0;
            }
            do
            {
                if (arr[i] == arrayOfPositions[i])
                    i++;
                else
                {
                    int temp = arr[i];
                    int position = arrayOfPositions[arr[i]-1] - 1;
                    arr[i] = arr[position];
                    arr[position] = temp;
                    swaps++;
                }
            } while (i < arr.Length);
            return swaps;
        }

        private static int[] GenerateHelpArray(int[] arr)
        {
            int[] arrayOfPositions = new int[arr.Length];
            for (int j = 0; j < arr.Length; j++)
            {
                arrayOfPositions[j] = j + 1;
            }

            return arrayOfPositions;
        }
    }
}
