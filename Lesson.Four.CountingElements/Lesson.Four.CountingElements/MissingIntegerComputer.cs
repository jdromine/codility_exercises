using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson.Four.CountingElements
{
    public class MissingIntegerComputer
    {
        public static int? Compute(int[] A)
        {
            //Filter out the negatives from the list and order
            var itemsGreaterThanZero = from item in A
                                       where item > 0
                                       orderby item
                                       select item;

            //Set the minimum expected next element
            int expectedNextElement = 1;

            //Initialize the min missing element with null
            int? minMissingElement = null;

            foreach (var item in itemsGreaterThanZero)
            {
                // if the current item == the expected next element, simply increment the expected element
                if (item == expectedNextElement)
                {
                    expectedNextElement++;
                }
                else if (item > expectedNextElement) // if the next element is greater than the expected next element, then the missing element has been found.
                {
                    minMissingElement = expectedNextElement;
                    break;
                }
            }

            return minMissingElement;
        }
    }
}
