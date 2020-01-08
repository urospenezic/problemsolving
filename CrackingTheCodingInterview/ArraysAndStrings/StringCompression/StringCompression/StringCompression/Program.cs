using System;
using System.Text;

namespace StringCompression
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            Console.WriteLine(CompressedString(input));
            Console.ReadKey();
        }

        private static string CompressedString(string input)
        {
            //aaaaabbbbccd
            //aaaaabbbbccc
            var builder = new StringBuilder();
            int countRepeated = 0;
            for (int i = 0; i < input.Length; i++)
            {
                countRepeated++;
                if(i==input.Length-1)
                {
                    builder.Append(input[i] + countRepeated.ToString());
                    break;
                }
                if (input[i] != input[i + 1])
                {
                    builder.Append(input[i] + countRepeated.ToString());
                    countRepeated = 0;
                }
            }
            return input.Length < builder.Length ? input : builder.ToString();
        }
    }
}
