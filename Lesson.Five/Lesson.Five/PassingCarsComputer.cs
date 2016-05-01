using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson.Five
{
    // For description of problem see https://codility.com/programmers/task/passing_cars/
    public class PassingCarsComputer
    {
        public static int Compute(int[] A)
        {
            int sumOfUnpassedCarsMovingWest = A.Sum();
            int countOfPassingCars = 0;

            //Loop through all cars
            for (int i=0; i<A.Length; i++)
            {
                // If the car is moving east (0), then all cars moving west (1) with a greater array index value will be passed.
                if (A[i] == 0)
                {
                    countOfPassingCars += sumOfUnpassedCarsMovingWest;
                } else // if the current car is moving west, we simply decrement the # of unpassed cars moving west.
                {
                    sumOfUnpassedCarsMovingWest -= A[i];
                }           
            }

            return countOfPassingCars;
        }
    }
}
