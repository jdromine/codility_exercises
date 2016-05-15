using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson.Five
{

    // For a description of the problem see https://codility.com/programmers/task/min_avg_two_slice/
    public class MinAvgTwoSliceComputer
    {
        public static int Compute(int[] A, int N)
        {
            if (A.Length <= 1)
            {
                throw new ArgumentException("Array lenth must be greater than 1.");
            }

            Dictionary<int, double> minimumAverageSlicesByIndex = new Dictionary<int, double>();

            for (int startingInt=0; startingInt < A.Length - 1; startingInt++)
            {
                minimumAverageSlicesByIndex.Add(startingInt, getSmallestAverageSliceForSinglePointInArray(A, startingInt));
            }

            return getIndexWithMinimumAverageSlice(minimumAverageSlicesByIndex);
        }

        private static double getSmallestAverageSliceForSinglePointInArray(int[] array, int startingIndex)
        {
            if (startingIndex >= array.Length - 1)
            {
                throw new ArgumentOutOfRangeException();
            }

            //Count the number of values between the starting index and end of the array 
            double totalCountOfValues = array.Length - startingIndex;
            double sumOfValues = 0;

            //TODO: Use lync for this
            for (int i=startingIndex; i<array.Length; i++)
            {
                sumOfValues += array[i];
            }

            double minimumAverage = sumOfValues / totalCountOfValues;

            for (int j=array.Length - 1; j>startingIndex; j--)
            {
                minimumAverage = Math.Min(minimumAverage, sumOfValues / totalCountOfValues);
                sumOfValues -= array[j];
                totalCountOfValues--;
            }

            return minimumAverage;
        }

        private static int getIndexWithMinimumAverageSlice(Dictionary<int, double> slices)
        {
            double minSlice;
            int minSliceIndex = 0;
                
            slices.TryGetValue(minSliceIndex, out minSlice);

            foreach(var slice in slices)
            {
                if (slice.Value < minSlice)
                {
                    minSlice = slice.Value;
                    minSliceIndex = slice.Key;
                }
            }

            return minSliceIndex;
        }
    }
}