using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplesAndOranges
{
    class Program
    {
        static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
        {
            int sumApples = 0;
            int sumOranges = 0;
            for (int i = 0; i < apples.Length; i++)
            {
                if (a + apples[i] >= s && a + apples[i] <= t)
                {
                    sumApples++;
                }
            }
            for (int j = 0; j < oranges.Length; j++)
            {
                if (b - oranges[j] <= t && b- oranges[j] >=s)
                {
                    sumOranges++;
                }
            }
            Console.WriteLine(sumApples);
            Console.WriteLine(sumOranges);
        }
        static void Main(string[] args)
        {
            Random rng = new Random();
            Console.WriteLine($"U zamisljenom 2D prostoru, uneti dimenziju kuce");
            Console.WriteLine("Uneti pocetnu tacku kuce:");
            int s = int.Parse(Console.ReadLine());
            Console.WriteLine("Uneti krajnju tacku kuce");
            int t = int.Parse(Console.ReadLine());
            Console.WriteLine("Uneti lokaciju drveta jabuke u odnosu na kucu:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Uneti lokaciju drveta pomorandze u odnosu na kucu:");
            int b = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int[] apples = new int[n];
            int[] oranges = new int[m];
            for (int i = 0; i < n; i++)
            {
                apples[i] = rng.Next(-15, 15);
            }
            for (int j = 0; j < m; j++)
            {
                oranges[j] = rng.Next(-15, 15);
            }
            foreach (var appl in apples)
            {
                Console.Write(appl + " ");
            }
            Console.WriteLine();
            foreach (var orange in oranges)
            {
                Console.Write(orange + " ");
            }
            countApplesAndOranges(s, t, a, b, apples, oranges);
        }
    }
}
