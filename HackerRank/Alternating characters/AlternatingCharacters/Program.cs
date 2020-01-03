using System;

namespace AlternatingCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string s = Console.ReadLine();

                int result = alternatingCharacters(s);

                Console.WriteLine(result);
            }
        }
        /// <summary>
        /// example
        /// aaabba
        /// make it to
        /// ababa with deletion on 1 a
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        private static int alternatingCharacters(string s)
        {
            int removal = 0;
            s.ToCharArray();
            if (s.Length < 2)
                return 0;
            for (int i = 0; i < s.Length-1; i++)
            {
                if (s[i + 1] == s[i])
                    removal++;
            }
            return removal;
        }
    }
}
