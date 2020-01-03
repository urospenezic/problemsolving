using System;

namespace SpecialStringAgain
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
        /// example
        /// aaaaababaadsdfga
        /// 
        /// </summary>
        /// <param name="n"></param>
        /// <param name="s"></param>
        /// <returns></returns>
        private static long substrCount(int n, string s)
        {
            int initialSubstringCount = s.Length;
            for (int i = 0; i < s.Length-1; i++)
            {
                
                
                
            }
            return initialSubstringCount;
        }
    }
}
