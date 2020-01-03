using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valleys
{
    class Program
    {
        static int countingValleys(int n, string s)
        {
            int valley = 0;
            char[] path = s.ToCharArray();
            int current = 0;
            for (int i = 0; i < path.Length; i++)
            {
                if (path[i] == 'D' && current == 0) valley++;
                if (path[i] == 'D') current -= 1;
                else if(path[i]=='U')current += 1;  
            }
            return valley;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Broj poteza:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Kuda se kretao?");
            string s = Console.ReadLine();
            int result = countingValleys(n, s);
            Console.WriteLine($"Number of Valleys: {result}");

        }
    }
}
