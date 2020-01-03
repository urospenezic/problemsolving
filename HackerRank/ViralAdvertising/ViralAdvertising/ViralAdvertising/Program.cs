using System;

namespace ViralAdvertising
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int result = viralAdvertising(n);
            Console.WriteLine(result);
        }

        private static int viralAdvertising(int n)
        {
            int shared = 5;
            int liked = 2;
            int cumulative = 0;
            var likedCumulative = new int[n];
            likedCumulative[0] = liked;
            for (int i = 1; i < n; i++)
            {
                shared = liked * 3;
                liked = shared / 2;
                likedCumulative[i] = liked;
            }
            foreach (var item in likedCumulative)
            {
                cumulative += item;
            }
            return cumulative;
        }
    }
}
