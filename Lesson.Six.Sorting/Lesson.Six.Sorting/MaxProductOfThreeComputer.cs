using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson.Six.Sorting
{
    //For description of problem, see https://codility.com/programmers/task/max_product_of_three/
    public class MaxProductOfThreeComputer
    {
        public static int Compute(int[] A)
        {
            if (A.Length < 3)
            {
                throw new ArgumentException("The array must have 3 or more integers in order to compute the max product of three!");
            }

            Array.Sort(A);

            //After sorting, the max product of three should be the last 3 numbers unless there are both negative and positive numbers.
            int maxProductOfThree = A[A.Length - 1] * A[A.Length - 2] * A[A.Length - 3];

            //Handle the case with  negatives and positives
            maxProductOfThree = Math.Max(maxProductOfThree, (A[0] * A[1] * A[A.Length - 1]));

            return maxProductOfThree;
        }
    }
}
