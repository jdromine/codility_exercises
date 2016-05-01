using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson.Four.CountingElements
{
    // For a description of the problem see https://codility.com/programmers/task/max_counters/
    public class MaxCountersComputer
    {
        public static int[] Compute(int[] A, int N)
        {
            int[] counters = new int[N];
            int maxCounter = 0;
            int counterValue = 0;

            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    counterValue = counters[j];
                    int x = j + 1;

                    if (A[i] == (N + 1))
                    {
                        counterValue = maxCounter;
                    }
                    else if (A[i] == x && 1 <= x && x <= N)
                    {
                        counterValue++;
                    }

                    maxCounter = Math.Max(maxCounter, counterValue);
                    counters[j] = counterValue;
                }
            }

            return counters;
        }
    }
}
