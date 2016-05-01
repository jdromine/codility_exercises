using System.Linq;

namespace Lesson.Two
{
    // For a description of the problem, see https://codility.com/programmers/task/odd_occurrences_in_array/
    public class OddOccurrencesInArrayComputer
    {
        public static int Compute(int[] N)
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
