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
            Console.WriteLine(GenomicRangeQueryComputer.Compute("CAGCCTA", new int[] { 2, 5, 0 }, new int[] { 4, 5, 6 }));
        }
    }
}
