using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{

    // Complete the diagonalDifference function below.
    static int diagonalDifference(int[][] arr)
    {
        int sum1 = 0;
        int sum2 = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr.Length; j++)
            {
                if (i == j)
                { sum1 += arr[i][j]; }
                else if (i + j == arr.Length)
                { sum2 += arr[i][j]; }
            }
        }
        return Math.Abs(sum1 - sum2);
    }

    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[][] arr = new int[n][];
        Random rng = new Random();
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                arr[i][j] = rng.Next(-100, 100);
            }
        }




        int result = diagonalDifference(arr);
        Console.WriteLine(result);

    }
}

