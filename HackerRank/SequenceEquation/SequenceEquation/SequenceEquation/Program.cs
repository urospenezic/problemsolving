using System;
using System.Collections.Generic;

namespace SequenceEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] p = Array.ConvertAll(Console.ReadLine().Split(' '), pTemp => Convert.ToInt32(pTemp))
            ;
            int[] result = permutationEquation(p);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        private static int[] permutationEquation(int[] p)
        {
            var result = new List<int>();
            for (int i = 1; i < p.Length+1; i++)
            {
                for (int j = 0; j < p.Length; j++)
                {
                    if(p[p[j]-1]==i)
                    {
                        result.Add(j+1);
                        break;
                    }
                }
            }
            return result.ToArray();
        }
    }
}
