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
            double expectedLength = N.Length + 1;
            double expectedSum = (expectedLength / 2) * (expectedLength + 1);
            double actualSum = N.Sum();

            return (long)expectedSum - (long)actualSum;
        }
    }
}
