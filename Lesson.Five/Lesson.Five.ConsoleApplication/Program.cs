using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson.Five.ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            GenomicRangeQueryComputer genomicRangeQueryComputer = new GenomicRangeQueryComputer();
            Console.WriteLine(genomicRangeQueryComputer.Compute("CAGCCTAB", new int[] { 2, 5, 0 }, new int[] { 4, 5, 7 }));
            //Console.WriteLine(MinAvgTwoSliceComputer.Compute(new int[] { 4, 2, 2, 5, 1, 5, 8 }, 7));
        }
    }
}
