using System;
using System.Collections.Generic;
using System.Linq;

namespace Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new LinkedList<char>();
            var input= Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToChar);
            foreach (var character in input)
            {
                list.AddLast(character);
            }
            Console.WriteLine(CheckIfPalindrome(list));
        }

        private static string CheckIfPalindrome(LinkedList<char> list)
        {
            var hashTable = new Dictionary<char, int>();
            var current = list.First;
            while (current!=null)
            {
                if(!hashTable.ContainsKey(current.Value))
                hashTable.Add(current.Value, 1);
                else
                hashTable[current.Value]++;
                current = current.Next;
            }
            int dangerCount = 0;
            foreach (var number in hashTable.Values.ToArray())
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
