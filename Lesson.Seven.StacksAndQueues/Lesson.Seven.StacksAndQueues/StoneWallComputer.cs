using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson.Seven.StacksAndQueues
{
    // For a description of the problem see https://codility.com/programmers/task/stone_wall/
    public class StoneWallComputer
    {
        public static int Compute(int[] H)
        {
            Stack<int> resuableStones = new Stack<int>();
            int totalStoneCount = 0;

            for (int i = 0; i<H.Length; i++)
            {
                int currentStoneHeight = H[i];

                bool foundReusableStone = false;
                bool foundSmallerWall = false;

                while (resuableStones.Count != 0 && !foundReusableStone && !foundSmallerWall)
                {
                    if (resuableStones.Peek() == currentStoneHeight)
                    {
                        foundReusableStone = true;
                    } else if(resuableStones.Peek() > currentStoneHeight)
                    {
                        resuableStones.Pop();
                    } else
                    {
                        foundSmallerWall = true;                            
                    }
                }

                if (!foundReusableStone)
                {
                    totalStoneCount++;
                    resuableStones.Push(currentStoneHeight);
                }

            }

            return totalStoneCount;
        }
    }
}
