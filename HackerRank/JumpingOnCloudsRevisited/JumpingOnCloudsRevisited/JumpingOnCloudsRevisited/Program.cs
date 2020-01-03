using System;

namespace JumpingOnCloudsRevisited
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nk = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);

            int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp))
            ;
            int result = jumpingOnClouds(c, k);
            Console.WriteLine(result);
        }

        private static int jumpingOnClouds(int[] c, int k)
        {
            int energyBar = 100;
            int length = c.Length;
            int position = 0;
            for (int i = 0; i < c.Length/k; i++)
            {
                if (c[(position + k) % c.Length] == 1)
                {
                    energyBar -= 3;
                }
                else
                {
                    energyBar -= 1;
                }
                position = (position + k)%length;
            }
            return energyBar;
        }
    }
}
