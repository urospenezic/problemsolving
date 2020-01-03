using System;
using System.Linq;

namespace Making_Anagrams
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();

            string b = Console.ReadLine();

            int res = MakeAnagram(a, b);
            Console.WriteLine(res);
        }
        /// <summary>
        /// aaadvvf
        /// aadvf
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        private static int MakeAnagram(string a, string b)
        {
            int countTimesDeleted = 0;
            var letters = new int[26];
            for (int i = 0; i < a.Length; i++)
            {
                letters[a[i] - 'a']++;
            }
            foreach (var character in b)
            {
                letters[character - 'a']--;
            }
            for (int i = 0; i < letters.Length; i++)
            {
                countTimesDeleted += Math.Abs(letters[i]);
            }
            return countTimesDeleted;
        }
    }
}
