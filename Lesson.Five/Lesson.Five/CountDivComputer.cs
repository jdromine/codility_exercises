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
            int firstDiv = (A + (A % K)); 

            if (firstDiv > B)
            {
                return 0;
            }

            //Find the last integer divisible by K between A and B
            int lastDiv = (B - (B % K));

            if (lastDiv < A)
            {
                return 0;
            }

            //Check if there is a Div between A & B
            if (lastDiv - firstDiv < K)
            {
                return 0;
            }
            else
            {
                return ((lastDiv - firstDiv) / K) + 1;
            }
        }
    }
}
