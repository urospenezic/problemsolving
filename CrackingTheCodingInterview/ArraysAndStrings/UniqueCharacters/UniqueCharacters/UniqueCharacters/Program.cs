using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace UniqueCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write an algorithm to check if a string has all unique characters
            var stringToCheck = Console.ReadLine();
            CheckIfUnique(stringToCheck);
            Console.ReadKey();
        }

        private static void CheckIfUnique(string stringToCheck)
        {
            if(stringToCheck.Length<1)
                Console.WriteLine("Invalid string");
            if(stringToCheck.Length==1)
                Console.WriteLine("YES");
            var table = new Dictionary<char, int>();
            foreach (var character in stringToCheck)
            {
                if (!table.ContainsKey(character))
                    table.Add(character, 1);
                else
                    table[character]++;
            }
            var check=table.Any(pair => pair.Value > 1);
            if(check)
                Console.WriteLine("NO");
            else
                Console.WriteLine("YES");
        }
    }
}
