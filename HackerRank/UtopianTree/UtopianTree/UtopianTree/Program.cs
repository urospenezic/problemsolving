using System;

namespace UtopianTree
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                int result = utopianTree(n);
                Console.WriteLine(result);
            }
        }

        private static int utopianTree(int n)
        {
            int treeHight = 1;
            if (n == 0) return 1;
            for (int i = 1; i < n+1; i++)
            {
                if (i % 2 == 0)
                    treeHight++;
                else
                    treeHight *= 2;
            }
            return treeHight;
        }
    }
}
