using System;
using System.Collections.Generic;
using System.Linq;

namespace CutTheSticks
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            ;
            int[] result = cutTheSticks(arr);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        private static int[] cutTheSticks(int[] arr)
        {
            var result = new List<int>();
            var list = arr.ToList();
            result.Add(list.Count());
            while (list.Count!=0)
            {
                var min = list.Min();
                list.RemoveAll(a => a == min);
                result.Add(list.Count);
                list.ForEach(a => a-=min);
            }
            result.Remove(0);
            return result.ToArray();
        }
    }
}
