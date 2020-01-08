using System;
using System.Collections.Generic;
using System.Linq;

namespace PalindromePermutation
{
    class Program
    {
        static void Main(string[] args)
        {
            var v1 = Console.ReadLine();
            Console.WriteLine(CheckIfPermutatedPalindrome(v1));
            Console.ReadKey();
        }

        private static string CheckIfPermutatedPalindrome(string v1)
        {
            var hashtable = new Dictionary<char, int>();
            foreach (var character in v1)
            {
                if (!hashtable.ContainsKey(character) && character != ' ')
                    hashtable.Add(character, 1);
                else if (character != ' ')
                    hashtable[character]++;
            }
            int dangerCount = 0;
            foreach (var number in hashtable.Values.ToArray())
            {
                if (number % 2 != 0)
                    dangerCount++;
                if (dangerCount > 1)
                    return "NO";
            }
            return "YES";
        }
    }
}
