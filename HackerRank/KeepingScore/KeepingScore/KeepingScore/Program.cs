using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeepingScore
{
    class Program
    {
        static int[] breakingRecords(int[] scores)
        {
            int min = scores[0];
            int max = scores[0];
            int recordMin = 0;
            int recordMax = 0;
            for (int i = 1; i < scores.Length; i++)
            {
                if (min > scores[i])
                {
                    min = scores[i];
                    recordMin++;
                }
                if (max < scores[i])
                {
                    max = scores[i];
                    recordMax++;
                }
            }
            int[] result = new int[] { recordMax, recordMin };
            return result;

        }
        static void Main(string[] args)
        {
            Random rng = new Random();
            int n = int.Parse(Console.ReadLine());
            int[] scores = new int[n];
            for (int i = 0; i < n; i++)
            {
                scores[i] = rng.Next(0, 100);
                Console.Write(scores[i] + " ");
            }
            Console.WriteLine();
            int[] ispis = breakingRecords(scores);
            Console.WriteLine(string.Join(" ", ispis));
        }
    }
}
