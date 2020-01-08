using System;

namespace SearchInRotatedArray
{
    class Program
    {
        // Given a sorted array of n integers that has been rotated an unknown number of times, write a code to find
        // an element in the array. You may assume that the array was originally sorted in increasing order
        static void Main(string[] args)
        {
            int[] testArray = new int[]{45, 15, 20, 25, 30, 35, 40};
            int index= Find(testArray, 0, testArray.Length-1, 25);
            System.Console.WriteLine(index);
        }

        private static int Find(int[] testArray, int left, int right, int x)
        {
            int mid = (left + right) / 2;
            if(x== testArray[mid])
            return mid;
            if(right<left)
            return -1;

            if(testArray[left]<testArray[mid]) // not rotated or got back to original form
            {
                if(x >= testArray[left] && x < testArray[mid])
                    return Find(testArray, left, mid-1, x);
                else
                    return Find(testArray, mid + 1, right, x);
            }
            else if(testArray[mid] < testArray[left]) //right side is normally ordered
            {
                if(x>testArray[mid] && x<=testArray[right])
                    return Find(testArray, mid + 1, right, x);
                else
                    return Find(testArray, left, mid-1, x);
            }
            else if(testArray[left] == testArray[mid]) // a lot of repeated ints
            {
                if(testArray[mid]!=testArray[right])
                    return Find(testArray, mid+1, right,x);
                else
                    {
                        int result = Find(testArray,left,mid-1,x);
                        if(result==-1)
                        return Find(testArray,mid+1,right,x);
                        else
                        return result;
                    }
            }
            return -1; //unexpected error
        }
    }
}
