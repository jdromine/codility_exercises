using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson.Three
{
    // For a description of the problem see https://codility.com/programmers/task/frog_jmp/
    public class FrogJumpComputer
    {
        public static int Compute(int X, int Y, int D)
        {
            //Assuming D <> 0 
            int distanceToJump = (Y - X);
            return distanceToJump / D + (distanceToJump % D == 0 ? 0 : 1);
        }
    }
}
