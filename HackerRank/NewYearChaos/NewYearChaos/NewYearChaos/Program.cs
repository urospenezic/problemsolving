using System;

namespace NewYearChaos
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                int[] q = Array.ConvertAll(Console.ReadLine().Split(' '), qTemp => Convert.ToInt32(qTemp))
                ;
                minimumBribes(q);
            }
        }
        /// <summary>
        /// example que
        /// 2
        /// 8
        /// 5 1 2 3 7 8 6 4
        /// 8
        /// 1 2 3 4 5 6 7 8
        /// 1 2 5 3 7 8 6 4
        /// </summary>
        /// <param name="q"></param>
        /// Moze kao insertion varijanta ili merge
        private static void minimumBribes(int[] q)
        {
            bool isChaotic = false;
            int bribes = 0;
            for (int i = q.Length - 1; i >= 0; i--)
            {
                int actualPosition = i - q[i] - 1;
                int position = q[i] - (i + 1);
                if (position > 2)
                {
                    Console.WriteLine("Too chaotic");
                    isChaotic = true;
                    break;
                }
                for (int j = Math.Max(0, q[i] - 2); j < i; j++)
                {
                    if (q[j] > q[i])
                        bribes++;
                }
            }
            if (!isChaotic)
                Console.WriteLine(bribes);
        }
    }
}
