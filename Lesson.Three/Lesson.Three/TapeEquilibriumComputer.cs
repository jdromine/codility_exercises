using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson.Three
{
    // For a description of the problem see https://codility.com/programmers/task/tape_equilibrium/
    public class TapeEquilibriumComputer
    {
        public static long? Compute(int[] N)
        {
            long totalSumOfIntegersInArray = N.Sum();
            long? minimumDifference = new long?();
            long currentDifference;
            long sumOfIntegersBeforeCurrentIndex = 0;
            long sumOfIntegersAfterCurrentIndex = totalSumOfIntegersInArray;

            for (int i = 0; i < N.Length; i++)
            {
                sumOfIntegersBeforeCurrentIndex += N[i];
                sumOfIntegersAfterCurrentIndex -= N[i];
                currentDifference = Math.Abs(sumOfIntegersAfterCurrentIndex - sumOfIntegersBeforeCurrentIndex);

                minimumDifference = minimumDifference == null ? currentDifference : Math.Min((long)minimumDifference, currentDifference);
            }

            return minimumDifference;
        }
    }
}
