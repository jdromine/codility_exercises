using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson.Six.Sorting;

namespace Lesson.Six.Sorting.ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] array = QuickSortAlgorithm.Sort(new int[] { 5, 2, 3, 4, 1 });
            int[] array = MergeSortAlgorithm.Sort(new int[] { 5, 2, 3, 4, 1 });

        }
    }
}
