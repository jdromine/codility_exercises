using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson.Seven.StacksAndQueues
{

    // For a description of the problem see https://codility.com/programmers/task/fish/ 
    public class AliveFishComputer
    {
        public static int Compute(int[] A, int[] B)
        {
            if (A.Length <= 1)
            {
                return A.Length;
            } else
            {
                List<Fish> eatenFish = new List<Fish>();
                Fish currentFish = new Fish(A[0], B[0], 0);

                for (int i = 1; i < A.Length; i++)
                {
                    Fish otherFish = new Fish(A[i], B[i], i);

                    if (currentFish.WillMeet(otherFish))
                    {
                        if (currentFish.GetsEaten(otherFish))
                        {
                            eatenFish.Add(currentFish);
                            currentFish = otherFish;
                        } else
                        {
                            eatenFish.Add(otherFish);
                        }
                    } else
                    {
                        //Current fish can only eat if there are no alive fish positioned between current fish and next fish.
                        currentFish = otherFish;
                    }
                }

                return A.Length - eatenFish.Count;
            }
        }
    }

    public class Fish
    {
        private int _size;
        private int _direction;
        private int _position;
        
        public int Size { get { return _size; } }
        public int Direction { get { return _direction; } }
        public int Position { get { return _position; } }

        public Fish(int size, int direction, int position)
        {
            _size = size;
            _direction = direction;
            _position = position;
        }

        public bool WillMeet(Fish otherFish)
        {
            if (this.Position < otherFish.Position && this.Direction == Directions.DOWNSTREAM && otherFish.Direction == Directions.UPSTREAM)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public bool GetsEaten(Fish otherFish)
        {
            if (this.Size < otherFish.Size)
            {
                return true;
            } else
            {
                return false;
            }
        }
    }

    public class Directions
    {
        public const int DOWNSTREAM = 1;
        public const int UPSTREAM = 0;
    }

}
