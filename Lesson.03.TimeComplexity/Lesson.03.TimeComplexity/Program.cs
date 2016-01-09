using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson._03.TimeComplexity
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculator.CalculateTapeEquilibrium(new int[] { 3, 1, 2, 4, 3 }));
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

            rightSum = totalSum;

            for (int i = 0; i < N.Length; i++)
            {
                leftSum += N[i];
                rightSum -= N[i];
                currentDifference = Math.Abs(rightSum - leftSum);

                minimumDifference = minimumDifference == null ? currentDifference : Math.Min((long)minimumDifference, currentDifference);
            }

            return minimumDifference;
        }

    }
}
