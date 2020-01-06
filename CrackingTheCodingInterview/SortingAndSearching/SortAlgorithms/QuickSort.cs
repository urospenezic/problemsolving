using System;

namespace SortAlgorithms
{
    public static class QuickSort
    {
        public static void QuickSortTheArray(this int[] array, int left, int right)
        {
            int partition = Partition(array, left, right);
            if(left < partition -1)
            QuickSortTheArray(array, left, partition - 1);
            if(partition < right)
            QuickSortTheArray(array, partition, right);
        }

        private static int Partition(int[] array, int left, int right)
        {
            int pivot = array[(left + right) / 2];
            while (left <= right)
            {
                // find the element on the left side that should've been on right
                while(array[left] < pivot) left++;
                // find the element on the right side that should've been on the left
                while(array[right] > pivot) right--;
                //swap them
                if(left <= right)
                {
                    Swap(array, left, right);
                    left++;
                    right--;
                }
            }
            return left;
        }

        private static void Swap(int[] array, int left, int right)
        {
            int temp = array[left];
            array[left] = array[right];
            array[right] = temp;
        }
    }
}