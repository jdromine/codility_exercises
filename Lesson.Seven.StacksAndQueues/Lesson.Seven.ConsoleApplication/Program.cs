using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson.Seven.StacksAndQueues;

namespace Lesson.Seven.ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //AliveFishComputer.Compute(new int[] { 4, 3, 2, 1, 5 }, new int[] { 0, 1, 0, 0, 0 });

            //BracketNestingComputer computer = new BracketNestingComputer();
            //computer.Compute("{[()()]}");

            //StoneWallComputer.Compute(new int[] { 8, 8, 5, 7, 9, 8, 7, 4, 8 });

            NestingComputer.Compute("(()(())())");
        }
    }
}
