using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson.Six.Sorting
{
    public class SelectionSortAlgorithm 
    {
        public static void Sort(int[] array)
        {
            for (int i=0; i<array.Length - 1; i++)
            {
                int currentValue = array[i];
                int minValue = currentValue;
                int minValueIndex = i;

                for (int j=i+1; j<array.Length; j++)
                {
                    if (array[j] < minValue)
                    {
                        minValue = array[j];
                        minValueIndex = j;
                    }
                }

                if (i != minValueIndex)
                {
                    SortUtilities.Swap(array, i, minValueIndex);
                }
            }
        }
    }
}
