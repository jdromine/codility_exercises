using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson.Six.Sorting
{
    public class NumberOfIntersectingDiscsComputer
    {
        public static int Compute(int[] A, int maximumIntersectingDiscs)
        {
            int countOfIntersectingDiscs = 0;
            List<Disc> discs = new List<Disc>();

            for (int i = 0; i<A.Length; i++)
            {
                discs.Add(new Disc(i - A[i], i + A[i]));
            }

            for (int i=0; i<A.Length - 1; i++)
            {
                Disc discOne = discs[i];

                for (int j=i+1; j<A.Length; j++)
                {
                    Disc discTwo = discs[j];

                    if (discOne.Intersects(discTwo)){
                        countOfIntersectingDiscs++;
                    }
                }
            }

            if (countOfIntersectingDiscs >= maximumIntersectingDiscs)
            {
                return -1;
            } else
            {
                return countOfIntersectingDiscs;
            } 
        }
    }

    public class Disc
    {
        public int LeftCoordinate { get; set; }
        public int RightCoordinate { get; set; }

        public Disc(int left, int right)
        {
            this.LeftCoordinate = left;
            this.RightCoordinate = right;
        }

        public bool Intersects(Disc discTwo)
        {
            return this.IntersectsOnLeftSide(discTwo) || discTwo.IntersectsOnLeftSide(this) || this.Overlaps(discTwo) || discTwo.Overlaps(this);
        }

        private bool IntersectsOnLeftSide(Disc discTwo)
        {
            return discTwo.LeftCoordinate <= this.RightCoordinate && discTwo.LeftCoordinate >= this.LeftCoordinate;
        }

        private bool Overlaps(Disc discTwo)
        {
            return this.LeftCoordinate >= discTwo.LeftCoordinate && this.RightCoordinate <= discTwo.RightCoordinate;
        }
    }
}
