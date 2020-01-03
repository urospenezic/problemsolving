using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatsAndMouse
{
    class Program
    {
        static string catAndMouse(int x, int y, int z)
        {
            string result = "";
            if (Math.Abs(x - z) > Math.Abs(y - z))
            {
                result = "Cat B";
            }
            else if (Math.Abs(x - z) < Math.Abs(y - z)) result = "Cat A";
            else if (Math.Abs(x - z) == Math.Abs(y - z)) result = "Mouse C";
                return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Popuni macke i misa");
            int[] output = Array.ConvertAll(Console.ReadLine().Split(' '), outputTemp => Convert.ToInt32(outputTemp));
            string ispis= catAndMouse(output[0], output[1], output[2]);
            Console.WriteLine(ispis);

        }
    }
}
