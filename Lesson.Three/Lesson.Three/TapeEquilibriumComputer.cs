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
            long totalSum = N.Sum(i => i);
            long? minimumDifference = new long?();
            long currentDifference;
            long leftSum = 0;
            long rightSum = totalSum;

            for (int i = 0; i < N.Length; i++)
            {
                leftSum += N[i];
                rightSum -= N[i];
                currentDifference = Math.Abs(rightSum - leftSum);

                minimumDifference = minimumDifference == null ? currentDifference : Math.Min((long)minimumDifference, currentDifference);
            }

            return minimumDifference;
        }
    }
}
