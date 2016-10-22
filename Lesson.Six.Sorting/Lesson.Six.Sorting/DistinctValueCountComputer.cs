using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson.Six.Sorting
{
    public class DistinctValueCountComputer
    {
        public static int Compute(int[] A)
        {
            Dictionary<int, int> countOfEachInteger = new Dictionary<int, int>();

            for (int i=0; i<A.Length; i++)
            {
                if (countOfEachInteger.ContainsKey(A[i]))
                {
                    countOfEachInteger[A[i]]++;
                } else
                {
                    countOfEachInteger.Add(A[i], 1);
                }
            }

            return countOfEachInteger.Count;
        }
    }
}
