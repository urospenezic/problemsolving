using System;
using System.Collections.Generic;
using System.Linq;

namespace OneChangeAway
{
    // Problem: There are 3 operations you can perform on a string: Insert, Remove, Replace a character. Write a method to check if 2 strings are just 1 change (or 0) away from being identical
    class Program
    {
        static void Main(string[] args)
        {
            var strings = Console.ReadLine().Split(" ");
            Console.WriteLine(CheckIfOneAway(strings[0], strings[1]));
            Console.ReadKey();
        }
        // adfgtretasdg
        // adfgtretosd
        private static string CheckIfOneAway(string v1, string v2)
        {
            if (Math.Abs(v1.Length - v2.Length) > 1)
                return "NO";
            var hashtable = new Dictionary<char, int>();
            foreach (var character in v1)
            {
                if (!hashtable.ContainsKey(character))
                    hashtable.Add(character, 1);
                else
                    hashtable[character]++;
            }
            foreach (var character in v2)
            {
                if (!hashtable.ContainsKey(character))
                    hashtable.Add(character, 1);
                else
                    hashtable[character]--;
            }
            var valuesFromTable = hashtable.Values.Where(v => v != 0);
            if (valuesFromTable.Sum() < 3)
                return "YES";
            else
                return "NO";
        }
    }
}
