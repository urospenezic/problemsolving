using System;
using System.Collections.Generic;

namespace PermutationsWithoutDuplicates
{
    class Program
    {
        //write an algorithm to get all permutations of a given string
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var result = GetPermutations(input);
            foreach (var word in result)
            {
                Console.Write(word + ", ");
            }
        }

        private static List<string> GetPermutations(string input)
        {
            if(input==null) return null;
            var permutations = new List<string>();
            if(input.Length==0)
            {
                permutations.Add("");
                return permutations;
            }
            char prefix = input[0];
            string remainder = input.Substring(1);
            var words = GetPermutations(remainder);
            foreach (var word in words)
            {
                for (int i = 0; i <= word.Length; i++)
                {
                    var s = InsertCharAtPosition(word, prefix, i);
                    permutations.Add(s);
                }
            }
            return permutations;
        }

        private static string InsertCharAtPosition(string word, char prefix, int i)
        {
            var start = word.Substring(0,i);
            var end = word.Substring(i);
            return start + prefix + end;
        }
    }
}
