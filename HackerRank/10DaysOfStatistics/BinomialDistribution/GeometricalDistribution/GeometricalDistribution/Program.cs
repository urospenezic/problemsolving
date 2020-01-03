using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        int[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        double p = Math.Round((double)numbers[0] / numbers[1],3);
        int n = int.Parse(Console.ReadLine());
        double q = 1 - p;
        double result = 0;
        result = 1 - Math.Pow(q, n);
        Console.WriteLine(result.ToString("0.000"));
    }
}

