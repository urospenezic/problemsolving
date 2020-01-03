using System;

namespace CircularBufferRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nkq = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nkq[0]);

            int k = Convert.ToInt32(nkq[1]);

            int q = Convert.ToInt32(nkq[2]);

            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
            ;

            int[] queries = new int[q];

            for (int i = 0; i < q; i++)
            {
                int queriesItem = Convert.ToInt32(Console.ReadLine());
                queries[i] = queriesItem;
            }

            int[] result = circularArrayRotation(a, k, queries);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        private static int[] circularArrayRotation(int[] a, int k, int[] queries)
        {
            int position = k % a.Length;
            var helpArray = new int[queries.Length];
            for (int i = 0; i < queries.Length; i++)
            {
                if (queries[i] - position >= 0)
                    helpArray[i] = a[queries[i] - position];
                else
                    helpArray[i] = a[queries[i] - position + a.Length];
            }
            return helpArray;
        }
    }
}
