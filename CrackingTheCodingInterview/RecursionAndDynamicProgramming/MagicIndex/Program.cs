using System;

namespace MagicIndex
{
    class Program
    {
        // A magic index in an array A[0...n-1] is defined to be an index such that A[i] = i.
        // Given a sorted array of distinct integers, write a method to find a magic index, if one exists.
        static void Main(string[] args)
        {
            var input = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            Array.Sort(input);
            System.Console.WriteLine(FindMagicIndex(input));
        }
        // 1 2 3 4 4 5
        private static int FindMagicIndex(int[] input)
        {
            if(input.Length<1) return -1;
            var result = FindMagicIndex(input, 0, input.Length-1);
            return result;
        }

        private static int FindMagicIndex(int[] input, int start, int end)
        {
            if(end<start)
            return -1;
            int mid = (start+end) / 2;
            if(input[mid]==mid)
            return mid;
            else if(input[mid] > mid)
            return FindMagicIndex(input,start, mid-1);
            else
            return FindMagicIndex(input, mid+1, end);
        }
    }
}
