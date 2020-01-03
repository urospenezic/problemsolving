using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideChocolate
{
    class Program
    {
        static int birthday(List<int> s, int d, int m)
        {
            int sum = 0;
            int count = 0;

            for (int i = 0; i < s.Count-m; i++)
            {
                for (int j = i; j < i+m; j++)
                {
                    sum += s[j];
                }
                if (sum == d) count++;
                sum = 0;
            }
            return count;
        }
        static void Main(string[] args)
        {
            Random rng = new Random();
            Console.WriteLine("Meseci:");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Dani:");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine("Duzina cokolade");
            int n = int.Parse(Console.ReadLine()); 
            List<int> cokolada = new List<int>();
            for (int i = 0; i <n ; i++)
            {
                cokolada.Add(rng.Next(0,5));
                Console.Write(cokolada[i] + " ");
            }

        }
    }
}
