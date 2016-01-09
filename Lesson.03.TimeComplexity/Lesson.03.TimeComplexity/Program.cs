using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson._03.TimeComplexity
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator.CalculateMissingElement(new int[] { 2, 3, 1, 5 });
            Console.ReadLine();
        }
    }

    public class Calculator
    {
        public static long? CalculateTapeEquilibrium(int[] N)
        {
            long totalSum = N.Sum(i => i); 
            long? minimumDifference = new long?();
            long currentDifference;
            long leftSum = 0;
            long rightSum = totalSum;

            for (int i = 0; i < N.Length; i++)
            {
                leftSum += N[i];
                rightSum -= N[i];
                currentDifference = Math.Abs(rightSum - leftSum);

                minimumDifference = minimumDifference == null ? currentDifference : Math.Min((long)minimumDifference, currentDifference);
            }

            return minimumDifference;
        }

        public static long CalculateMissingElement(int [] N)
        {
            double expectedLength = N.Length + 1;
            double expectedSum = (expectedLength / 2) * (expectedLength + 1);
            double actualSum = N.Sum();

            return (long)expectedSum - (long)actualSum;
        }

    }
}
