using System;

namespace SparseSearch
{
    class Program
    {
        // given an sorted array of strings that's interspersed, write a code to find a string
        static void Main(string[] args)
        {
            var testArray = new string[]{"at", " ", " "," ", "ball", " ", " ", "car"," "," ","dad"," "};
            var x= "ball";
            int index = Find(testArray,0,testArray.Length-1,x);
            System.Console.WriteLine(index);
        }

        private static int Find(string[] testArray, int left, int right, string x)
        {
            int mid = (left+right) / 2;
            if(left>right)
            return -1;
            //if mid is an empty string, find the first non-empty one:
            if(String.IsNullOrWhiteSpace(testArray[mid]))
            {
                int low = mid-1;
                int high = mid +1;
                while (true)
                {
                    if(low<left && high>right)
                    return -1;
                    else if(high<=right && !String.IsNullOrWhiteSpace(testArray[high]))
                    {
                        mid = high;
                        break;
                    }
                    else if(low>=left && !String.IsNullOrWhiteSpace(testArray[low]))
                    {
                        mid=low;
                        break;
                    }
                    low++;
                    high++;
                }
            }
            // Do binary search:
            if(testArray[mid] == x)
            return mid;
            else if(testArray[mid].CompareTo(x)<0) //greater (go right)
            return Find(testArray, mid+1, right,x);
            else
            return Find(testArray,left, mid-1, x);
        }
    }
}
