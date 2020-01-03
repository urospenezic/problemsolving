using System;
using System.Collections.Generic;
using System.Linq;

namespace EqualizeArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            ;
            int result = equalizeArray(arr);
            Console.WriteLine(result);
        }

        private static int equalizeArray(int[] arr)
        {
            var result = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (result.ContainsKey(arr[i]))
                    result[arr[i]]++;
                else
                    result.Add(arr[i], 1);
            }
            return arr.Length - result.Values.Max();
        }
    }
}
