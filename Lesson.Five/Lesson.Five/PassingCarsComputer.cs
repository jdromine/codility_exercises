using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson.Five
{
    // For a description of the problem see https://codility.com/programmers/task/passing_cars/
    public class PassingCarsComputer
    {
        public static int Compute(int[] A)
        {
            int sumOfUnpassedCarsMovingWest = A.Sum();
            int countOfCarsPassed = 0;

            //Loop through all cars
            for (int i=0; i<A.Length; i++)
            {
                // If the car is moving east (0), then all cars moving west (1) with a greater array index value will be passed.
                if (A[i] == CarDirection.EAST)
                {
                    countOfCarsPassed += sumOfUnpassedCarsMovingWest;
                } else // if the current car is moving west, we simply decrement the # of unpassed cars moving west.
                {
                    sumOfUnpassedCarsMovingWest -= A[i];
                }           
            }

            return countOfCarsPassed;
        }
    }

    public static class CarDirection
    {
        public const int EAST = 0;
        public const int WEST = 1;
    }
}
