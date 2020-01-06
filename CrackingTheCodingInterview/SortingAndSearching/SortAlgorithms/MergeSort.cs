using System;

namespace SortAlgorithms
{
    public static class MergeSort
    {
        public static void Merge(this int[] array)
        {
            int[] helper = new int[array.Length];
            Merge(array, helper, 0, array.Length-1);
        }
        private static void Merge(int[] array, int[] helper, int low, int high)
        {
            if(low < high)
            {
                int middle = (low + high) / 2;
                Merge(array, helper, low, middle); // divide left side as much as possible
                Merge(array, helper, middle+ + 1, high); // divide the right side of previously divided left side as much as possible
                MergeArrays(array, helper, low, middle, high); // start sorting element by element from ground up
            }
        }

        private static void MergeArrays(int[] array, int[] helper, int low, int middle, int high)
        {
            for (int i = low; i <= high; i++)
            {
                helper[i] = array[i];
            }

            int helperLeft = low;
            int helperRight = middle + 1;
            int current = low;

            while (helperLeft <= middle && helperRight <= high)
            {
                if(helper[helperLeft] <= helper[helperRight])
                {
                    array[current] = helper[helperLeft];
                    helperLeft++;
                }
                else
                {
                    array[current] = helper[helperRight];
                    helperRight++;
                }
                current++;
            }

            int remainder = middle - helperLeft;
            for (int i = 0; i <= remainder; i++)
            {
                array[current + i] = helper[helperLeft + i];
            }
        }
    }
}

