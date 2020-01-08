using System;
using System.Text;

namespace StringRotation
{
    class Program
    {
        /// <summary>
        /// assume you have a method IsSubstring which checks if one word is a substring of another.
        /// given 2 strings, write a code to check if s2 is a rotation of s1 using only 1 call to IsSubstring
        /// example:  waterbottle is a rotation of erbottlewat
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var s = Console.ReadLine().Split(" ");
            Console.WriteLine(CheckIfRotation(s[0], s[1]));
        }

        private static string CheckIfRotation(string v1, string v2)
        {
            char start = v1[0];
            var builder = new StringBuilder();
            for (int i = v2.IndexOf(start); i < v2.Length; i++)
            {
                builder.Append(v2[i]);
            }
            builder.Append(v2);
            return IsSubString(v1, builder);
        }

        private static string IsSubString(string v1, StringBuilder builder)
        {
            if (builder.ToString().Contains(v1))
                return "YES";
            else
                return "NO";
        }
    }
}
