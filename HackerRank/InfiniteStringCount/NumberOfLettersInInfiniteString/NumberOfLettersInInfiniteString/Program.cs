using System;
using System.Collections;
using System.Linq;

namespace NumberOfLettersInInfiniteString
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            long n = Convert.ToInt64(Console.ReadLine());

            long result = repeatedString(s, n);
            Console.WriteLine(result);
        }
        //example abac count a's 100000000 times
        private static long repeatedString(string s, long n)
        {
            var substring = s.ToCharArray();
            var divider = n / substring.Count();
            var remainder = n % substring.Count();
            var numberOfA = substring.Where(a => a.Equals('a')).Count();
            var restofA = substring.Take(Convert.ToInt16(remainder)).Where(a=>a.Equals('a')).Count();
            return numberOfA * divider + restofA;
        }
    }
}
