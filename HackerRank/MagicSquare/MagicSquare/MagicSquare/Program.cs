using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicSquare
{
    class Program
    {
        static int formingMagicSquare(int[][] s)
        { // ko ga jebe, ubaci all possible i saltaj kroz njih da nadjes najmanji cost
            //sve moguce kombinacije:
            int[][] combos = new int[][]
                {
                    new int[]{ 8, 1, 6, 3, 5, 7, 4, 9, 2 },
                    new int[]{ 6, 1, 8, 7, 5, 3, 2, 9, 4 },
                    new int[]{ 4, 9, 2, 3, 5, 7, 8, 1, 6 },
                    new int[]{ 2, 9, 4, 7, 5, 3, 6, 1, 8 },
                    new int[]{ 8, 3, 4, 1, 5, 9, 6, 7, 2 },
                    new int[]{ 4, 3, 8, 9, 5, 1, 2, 7, 6 },
                    new int[]{ 6, 7, 2, 1, 5, 9, 8, 3, 4 },
                    new int[]{ 2, 7, 6, 9, 5, 1, 4, 3, 8 }
                };
            // izvrti combo i popunjavas niz za count
            int iteratorArray = 0;
            int[] costs = new int[8] { 0, 0, 0, 0, 0, 0, 0, 0 };
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if(i==0 && j==0)
                    iteratorArray--;
                    if (iteratorArray == 9)
                        break;
                    iteratorArray++;
                    for (int k = 0; k < 8; k++)
                    {
                        costs[k] += Math.Abs(combos[k][iteratorArray]-s[i][j]);
                        Console.WriteLine($"Cost za k= {k} postaje {costs[k]}");
                    }
                }
            }
            // vrati count min
            return costs.Min();
        }


        static void Main(string[] args)
        {

            int[][] s = new int[3][];
            Console.WriteLine("Unesi matricu:");
            for (int i = 0; i < 3; i++)
            {
                s[i] = Array.ConvertAll(Console.ReadLine().Split(' '), sTemp => Convert.ToInt32(sTemp));
            }
            int result = formingMagicSquare(s);
            Console.WriteLine(result);

        }
    }
}
