using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson.Five
{
    //For description of problem, see https://codility.com/programmers/task/count_div/
    public class CountDivComputer
    {

        public static int Compute(int A, int B, int K){
            //Find the first integer divisible by K between A and B
            int firstDivisibleIntegerInRange = (A + (A % K)); 

            if (firstDivisibleIntegerInRange > B)
            {
                //there are no integers divisible by K
                return 0;
            }

            int lastDivisibleIntegerInRange = (B - (B % K));

            if (lastDivisibleIntegerInRange < A)
            {
                //there are no integers divisible by K
                return 0;
            }

            if (lastDivisibleIntegerInRange - firstDivisibleIntegerInRange < K)
            {
                //there are no integers divisible by K
                return 0;
            }
            else
            {
                return ((lastDivisibleIntegerInRange - firstDivisibleIntegerInRange) / K) + 1 //Add 1 to handle the case where there is only one integer divisible by K;
            }
        }
    }
}
