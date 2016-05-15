using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson.Three
{
    // For a description of the problem see https://codility.com/programmers/task/perm_missing_elem/
    public class MissingElementComputer
    {
        public static long Compute(int[] N)
        {
            //Assuming that there is only one missing element
            double expectedLengthOfArray = N.Length + 1;
            double expectedSumOfIntegersInArray = (expectedLengthOfArray / 2) * (expectedLengthOfArray + 1);
            double actualSumOfIntegersInArray = N.Sum();

            return (long)expectedSumOfIntegersInArray - (long)actualSumOfIntegersInArray;
        }
    }
}
