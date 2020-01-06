using System;

namespace BinarySearch
{
    public static class BinarySearch
    {
        public static int Binary(this int[] array, int x)
        {
            int low = 0;
            int high = array.Length - 1;
            int mid;
            while (low <= high)
            {
                mid = (low + high) / 2;
                if(array[mid] < x)
                low = mid + 1;
                else if(array[mid] > x)
                high = mid -1;
                else
                return mid;
            }
            return -1; // error
        }
        public static int Binary(this int[] array, int x, int low, int high)
        {
            if(low > high) return -1; // error
            int mid = (low + high) / 2;
            if(array[mid] < x)
            Binary(array, x, mid + 1, high);
            else if(array[mid] > x)
            Binary(array, x, low, mid -1);
            else
            return mid;

            return -1; // unexpected error
        }
    }
}
