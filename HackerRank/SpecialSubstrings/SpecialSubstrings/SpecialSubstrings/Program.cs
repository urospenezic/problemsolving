using System;

namespace SpecialSubstrings
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            string s = Console.ReadLine();

            long result = substrCount(n, s);

            Console.WriteLine(result);
        }
        /// <summary>
        /// Example
        /// aaaabacdfafabvk
        /// </summary>
        /// <param name="n"></param>
        /// <param name="s"></param>
        /// <returns></returns>
        /// aaaab
        private static long substrCount(int n, string s)
        {

            long numberOfSubstrings = s.Length;
            if (s.Length < 2)
                return 1;
            for (int i = 0; i < n; i++)
            {
                int position = i + 1;
                if (s[i] == s[position])
                {
                    while (s[position] == s[i] && position < n - 1)
                    {
                        position++;
                    }

                    if (s[position] != s[position - 1])
                        position--;
                    numberOfSubstrings += ((position - i + 1) * (position - i)) / 2;
                }
                if (position == n - 1)
                    return numberOfSubstrings;
                else
                    i = position - 1;
                if (i < n - 2 && s[i] == s[i + 2])
                    numberOfSubstrings++;
            }
            return numberOfSubstrings;
        }
    }
}
