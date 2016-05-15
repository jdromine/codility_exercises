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
            //Create hash to track each integer in the array and it's count of occurrences
            Dictionary<int, int> integerOccurrencesInArray = new Dictionary<int, int>();

            int maxIntegerValueInArray = 0;
            bool arrayContainsDuplicateIntegerValues = false;
            int currentIntegerValueInArray;

            for (int i = 0; i < A.Length; i++)
            {
                currentIntegerValueInArray = A[i];

                //track the max item - if there are no missing elements, the max item value should equal the total number of elements
                maxIntegerValueInArray = Math.Max(maxIntegerValueInArray, currentIntegerValueInArray);

                //check for duplicates
                if (integerOccurrencesInArray.ContainsKey(currentIntegerValueInArray))
                {
                    integerOccurrencesInArray[currentIntegerValueInArray]++;
                    arrayContainsDuplicateIntegerValues = true;
                    break; //Exit loop since the array is not a permutation
                }
                else
                {
                    integerOccurrencesInArray.Add(currentIntegerValueInArray, 1);
                }
            }

            //finally check if the array is a permutation
            if (integerOccurrencesInArray.Count == maxIntegerValueInArray && !arrayContainsDuplicateIntegerValues)
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
