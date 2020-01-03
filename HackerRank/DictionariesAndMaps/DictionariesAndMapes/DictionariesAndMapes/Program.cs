using System;
using System.Collections.Generic;

namespace DictionariesAndMapes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var phonebook = new Dictionary<string, int>();
            for (int i = 0; i < n; i++)
            {
                string[] words = Console.ReadLine().Split();
                if (phonebook.ContainsKey(words[0]))
                    phonebook[words[0]] = int.Parse(words[1]);
                else
                    phonebook.Add(words[0], int.Parse(words[1]));
            }
            string query = Console.ReadLine();
            while (query!=null)
            {
                if(phonebook.ContainsKey(query))
                    Console.WriteLine(query+"="+phonebook[query]);
                else
                    Console.WriteLine("Not found");
                query = Console.ReadLine();
            }
        }
    }
}
