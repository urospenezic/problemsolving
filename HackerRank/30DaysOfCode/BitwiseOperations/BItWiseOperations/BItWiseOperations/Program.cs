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

    static void Main(string[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++)
        {
            string[] nk = Console.ReadLine().Split(' '); 

            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);
            if (((k - 1) | k) > n && k % 2 == 0)
            {
                Console.WriteLine(k - 2);
            }
            else
            {
                Console.WriteLine(k - 1);
            }
        }
    }
}
