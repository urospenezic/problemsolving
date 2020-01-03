using System;
using System.Linq;

namespace CutTheString
{
    class Program
    {
        static void Main(String[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            int testNumber = int.Parse(Console.ReadLine());
            for (int i = 0; i < testNumber; i++)
            {
                var initialString = Console.ReadLine();
                SplitTheString(initialString);
            }

        }
        static void SplitTheString(string initialString)
        {
            var stringOne = "";
            var stringTwo = "";
            for (int i = 0; i < initialString.Length; i++)
            {
                if (i % 2 == 0)
                    stringOne += initialString[i];
                else
                    stringTwo += initialString[i];
            }
            Console.WriteLine(stringOne + " " + stringTwo);
        }
    }
}
