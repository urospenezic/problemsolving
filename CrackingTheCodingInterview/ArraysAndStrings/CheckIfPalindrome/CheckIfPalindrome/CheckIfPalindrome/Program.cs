using System;
using System.Collections.Generic;
using System.Linq;

namespace CheckIfPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            var vs = Console.ReadLine().Split(" ");
            Console.WriteLine(CheckPermutation(vs[0], vs[1]));
            Console.ReadKey();
        }

        private static string CheckPermutation(string v1, string v2)
        {
            // afdstwesc
            // fswescadt
            if (v1.Length != v2.Length || v1.Length < 1 || v2.Length < 1)
                return "NO";
            var checking = new int[26];
            for (int i = 0; i < v1.Length; i++)
            {
                checking[v1[i] - 'a']++;
                checking[v2[i] - 'a']--;
            }
            if (checking.Any(n => n != 0))
                return "NO";
            else
                return "YES";
        }
    }
}
