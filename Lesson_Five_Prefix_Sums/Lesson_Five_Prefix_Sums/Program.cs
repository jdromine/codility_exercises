using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_Five_Prefix_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Calculator
    {

        public static int CalculateCountDiv(int A, int B, int K)
        {
            int firstDiv = Math.Min((A + (A % K)), B);
            int lastDiv = Math.Max((B - (B % K)), A);

            if (lastDiv - firstDiv < K)
            {
                return 0;
            } else
            {
                return ((lastDiv - firstDiv) / K) + 1;
            }    
        }
    }
}
