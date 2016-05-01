using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson.Four.CountingElements
{
    // For a description of the problem see https://codility.com/programmers/task/perm_check/
    public class PermCheckComputer
    {
        public static bool Compute(int[] A)
        {
            //Create hash to track each item in the array
            Dictionary<int, int> items = new Dictionary<int, int>();

            int maxItem = 0;
            bool maxCountGreaterThanOne = false;
            int currentItem;

            for (int i = 0; i < A.Length; i++)
            {
                currentItem = A[i];

                //track the max item - if there are no missing elements, the max item value should equal the total number of elements
                maxItem = Math.Max(maxItem, currentItem);

                //check for duplicates
                if (items.ContainsKey(currentItem))
                {
                    items[currentItem]++;
                    maxCountGreaterThanOne = true;
                }
                else
                {
                    items.Add(currentItem, 1);
                }
            }

            //finally check if the array is a permutation
            if (items.Count == maxItem && !maxCountGreaterThanOne)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
