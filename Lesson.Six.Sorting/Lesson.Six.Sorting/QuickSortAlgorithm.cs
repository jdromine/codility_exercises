using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson.Six.Sorting
{
    public class QuickSortAlgorithm
    {
        public static int[] Sort(int[] array)
        {
            Quicksort(array, 0, array.Length - 1);

            return array;
        }

        public static void Quicksort(int[] array, int left, int right)
        {
            int i = left;
            int j = right;
            int pivot = array[left + (right - left) / 2];

            while (i <= j)
            {
                //iterate until we find a value greater than the pivot
                while (array[i] < pivot)
                {
                    i++;
                }

                //iterate until we find a value less than the pivot
                while (array[j] > pivot)
                {
                    j--;
                }

                if (i <= j)
                {
                    SortUtilities.Swap(array, i, j);
                    i++;
                    j--;
                }
            }

            if (left < j)
            {
                Quicksort(array, left, j);
            }

            if (i < right)
            {
                Quicksort(array, i, right);
            }
        }
    }
}
