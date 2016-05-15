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
            var integersGreaterThanZero = from integer in A
                                       where integer > 0
                                       orderby integer
                                       select integer;

            //Set the minimum expected next integer
            int expectedNextInteger = 1;
            int? minMissingInteger = null;

            foreach (int currentInteger in integersGreaterThanZero)
            {
                // if the current item == the expected next element, simply increment the expected element
                if (currentInteger == expectedNextInteger)
                {
                    expectedNextInteger++;
                }
                else if (currentInteger > expectedNextInteger) // if the next element is greater than the expected next element, then the first missing integer has been found.
                {
                    minMissingInteger = expectedNextInteger;
                    break;
                }
            }

            return minMissingInteger;
        }
    }
}
