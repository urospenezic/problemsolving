using System;
using System.Linq;

namespace TheHurdleRace
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nk = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);

            int[] height = Array.ConvertAll(Console.ReadLine().Split(' '), heightTemp => Convert.ToInt32(heightTemp))
            ;
            int result = hurdleRace(k, height);
        }

        private static int hurdleRace(int k, int[] height)
        {
            var newHight = height.ToList();
            newHight.Sort();
            var highestHight = newHight[newHight.Count - 1];
            if (highestHight > k)
                return highestHight - k;
            else
                return 0;
        }
    }
}
