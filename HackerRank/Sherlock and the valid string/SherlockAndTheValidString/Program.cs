using System;
using System.Linq;

namespace SherlockAndTheValidString
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            string result = isValid(s);

            Console.WriteLine(result);
        }

        private static string isValid(string s)
        {
            var letters = new int[26];
            s.ToCharArray();
            foreach (var character in s)
            {
                letters[character - 'a']++;
            }
            //aabbcd
            var done = letters.Where(l => l != 0).OrderBy(l => l).ToArray();
            var maxOccurance = done.Max();
            var minOccurance = done.Min();
            if (minOccurance == maxOccurance)
                return "YES";
            else
            {
                if ((maxOccurance - minOccurance == 1) && (maxOccurance > done[done.Length - 2]) || (minOccurance == 1 && done[1] == maxOccurance))
                    return "YES";
                        
            }
            return "NO";
        }
    }
}
