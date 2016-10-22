using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson.Eight.LeaderLessons
{
    public class EquiLeaderComputer
    {
        public static int Compute(int[] A)
        {
            int countOfEquiLeaders = 0;

            for(int i=0; i<A.Length; i++)
            {
                int[] arrayLeft = new int[i + 1];
                int[] arrayRight = new int[A.Length - (i + 1)];

                Array.Copy(A, 0, arrayLeft, 0, i+1);
                Array.Copy(A, i + 1, arrayRight, 0, A.Length - (i + 1));

                int leftArrayLeader = LeaderUtilities.GetLeaderFromArray(arrayLeft);
                int rightArrayLeader = LeaderUtilities.GetLeaderFromArray(arrayRight);

                if (leftArrayLeader != -1 && leftArrayLeader == rightArrayLeader)
                {
                    countOfEquiLeaders++;
                }
            }

            return countOfEquiLeaders;
        }


    }
}
