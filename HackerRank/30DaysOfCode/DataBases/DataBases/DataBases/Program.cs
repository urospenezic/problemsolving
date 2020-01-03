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
        int N = Convert.ToInt32(Console.ReadLine());
        var table = new Dictionary<string, List<string>>();
        var listOfStuff = new List<string>();
        for (int NItr = 0; NItr < N; NItr++)
        {
            string[] firstNameEmailID = Console.ReadLine().Split(' ');

            string firstName = firstNameEmailID[0];

            var emailID = firstNameEmailID[1].Split('@');

            if (emailID[1].StartsWith("gmail"))
                listOfStuff.Add(firstName);

            if(!table.ContainsKey(firstName))
            {
                table.Add(firstName, new List<string>());
                table[firstName].Add(emailID[1]);
            }
            else
            {
                table[firstName].Add(emailID[1]);
            }
        }
        listOfStuff.Sort();
        foreach (var item in listOfStuff)
        {
            Console.WriteLine(item);
        }
        //PrintNamesOfUsers(table);
        
    }
    // the smart way
    private static void PrintNamesOfUsers(Dictionary<string, List<string>> table)
    {
        var query = table.Where(pair => pair.Value.Any(x => x.Contains("gmail"))).Select(x => x.Key).ToList();
        foreach (var item in query)
        {
            Console.WriteLine(item);
        }
    }
    
}
