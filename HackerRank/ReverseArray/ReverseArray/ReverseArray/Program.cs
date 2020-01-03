using System;

namespace ReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            ;
            for (int i = 0; i < arr.Length / 2; i++)
            {
                int temp = arr[i];
                arr[i] = arr[arr.Length -1 - i];
                arr[arr.Length - 1 - i] = temp;
            }
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
        }
    }
}
