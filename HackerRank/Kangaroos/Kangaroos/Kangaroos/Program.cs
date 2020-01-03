using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kangaroos
{
    class Program
    {
        static string kangaroo(int x1, int v1, int x2, int v2)
        {
            string ispis="NO";
            if (x1 < x2 && v2 > v1)
            {
                ispis = "NO";
            }
            else if (x2 == x1)
            {
                ispis = "YES";
            }
            else
            {
                for (int i = 0; i < int.MaxValue; i++)
                {
                    x1 += v1;
                    x2 += v2;
                    Console.WriteLine($"Novi x1= {x1} x2= {x2}");
                    if (x1 == x2)
                    {
                        ispis = "YES";
                        break;
                    }
                    else if (x1 > x2)
                    {
                        ispis = "NO";
                        break;
                    }
                }
            }
            return ispis;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Gde pocinje prvi kengur?");
            int x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Gde pocinje drugi kengur?");
            int x2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Kojom brzinom se krece prvi kengur?");
            int v1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Kojom brzinom se krece drugi kengur?");
            int v2 = int.Parse(Console.ReadLine());
            Console.WriteLine(kangaroo(x1, v1, x2, v2));
        }
    }
}
