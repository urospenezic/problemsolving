using System;

namespace SaveThePrisoner
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                string[] nms = Console.ReadLine().Split(' ');

                int n = Convert.ToInt32(nms[0]);

                int m = Convert.ToInt32(nms[1]);

                int s = Convert.ToInt32(nms[2]);

                int result = saveThePrisoner(n, m, s);
                Console.WriteLine(result);
            }
        }
        private static int saveThePrisoner(int n, int m, int s)
        {
            int a = s + m - 1;
            if(a>n)
            {
                if (a % n == 0)
                    return n;
                return a % n;
            }
            return a;
        }
    }   
}
