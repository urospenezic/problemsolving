using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staircase
{
    class Program
    {
        static void staircase(int n)
        {
            int brojac = 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j >= n - brojac)
                    {                    
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write("");
                    }
                }
                Console.WriteLine();
                brojac++;
            }
            
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            staircase(n);
        }
    }
}
