using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson.Four.CountingElements
{
    // For a description of the problem see https://codility.com/programmers/task/frog_river_one/
    public class FrogRiverOneComputer
    {
        public static int Compute(int[] A, int X)
        {
            Dictionary<int, bool> leaves = new Dictionary<int, bool>();

            int minTimeToCross = -1;

            for (int i = 0; i < A.Length; i++)
            {
                //Add the leaves required to cross if they haven't already been added.
                if (!leaves.ContainsKey(A[i]) && A[i] <= X)
                {
                    leaves.Add(A[i], true);
                }

                //If all leaves have been added, set the min time to cross and break
                if (leaves.Count == X)
                {
                    minTimeToCross = i;

                    break;
                }
            }

            return minTimeToCross;
        }
    }
}
