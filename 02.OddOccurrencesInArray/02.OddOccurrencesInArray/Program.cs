using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.OddOccurrencesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = Calculator.Calculate(new int[] { 9, 3, 9, 3, 9, 7, 9 });
        }
    }


    public class Calculator
    {
        public static int Calculate(int[] N)
        {
            var items = N.GroupBy(n => n).
                                 Select(group =>
                                     new
                                     {
                                         Item = group.Key,
                                         Count = group.Count()
                                     });

            return items.Where(i => i.Count % 2 != 0).First().Item;
        }
    }
}
