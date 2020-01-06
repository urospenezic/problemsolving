using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
namespace GroupAnagrams
{
    class Program
    {
        // write a code to group all anagrams of an array of strings together
        static void Main(string[] args)
        {
            
        }
        private class AnagramComparer<T> : IComparer<string> where T:IComparable
        {
            public int Compare([AllowNull] string x, [AllowNull] string y)
            {
                return SortChars(x).CompareTo(SortChars(y));
            }

            private string SortChars(string y)
            {
                var result = y.ToCharArray();
                Array.Sort(result);
                return new String(result);
            }
        }
    }
}
