using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson.Six.Sorting
{
    public class SortUtilities
    {
        public static void Swap(int[] array, int index1, int index2)
        {
            int index1_value = array[index1];
            array[index1] = array[index2];
            array[index2] = index1_value;
        }
    }
}
