using System;
using System.Collections.Generic;
using System.Linq;

namespace PowerSet
{
    // write an algorithm to return all subsets of a given set
    class Program
    {
        static void Main(string[] args)
        {
            var input = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse).ToList();
            System.Console.WriteLine();
            var subsets = GetSubsets(input, 0);
            PrintSets(subsets);
        }

        private static void PrintSets(List<List<int>> subsets)
        {
            foreach (var item in subsets)
            {
                foreach (var smt in item)
                {
                    System.Console.Write($"[{smt}]");
                }
                System.Console.WriteLine();
            }
        }

        private static List<List<int>> GetSubsets(List<int> set, int index)
        {
            List<List<int>> allSubsets;
            // the end of the list, we return empty result and break recursion
            // that empty list will be used to store single digit values later on when we clone the results into new subset.
            if(set.Count == index)
            {
                allSubsets = new List<List<int>>();
                allSubsets.Add(new List<int>());
            }
            // get all subsets for the next index
            else
            {
                allSubsets = GetSubsets(set, index + 1);
                int prefix = set.ElementAt(index);
                var moreSubsets = new List<List<int>>();
                foreach (var subset in allSubsets)
                {
                    var newSubset = new List<int>();
                    newSubset.AddRange(subset);
                    newSubset.Add(prefix);
                    moreSubsets.Add(newSubset);
                }
                allSubsets.AddRange(moreSubsets);
            }
            return allSubsets;
        }
    }
}
