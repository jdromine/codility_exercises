using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_Four_Counting_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator.CalculateMissingMinimumPositiveInteger(new int[] { 1, 3, 6, 5, 4, 1, 2 });
            Calculator.CalculateMinTimeFrogCanCrossRiver(new int[] { 1, 3, 1, 4, 2, 3, 5, 4 }, 5);

            Calculator.CalculateCounters(new int[] { 3, 4, 4, 6, 1, 4, 4 }, 5);
            Console.ReadLine();
        }
    }
   

    public class Calculator
    {
        public static int? CalculateMissingMinimumPositiveInteger(int[] A)
        {
            //Filter out the negatives from the list and order
            var itemsGreaterThanZero = from item in A
                    where item > 0
                    orderby item
                    select item;

            //Set the minimum expected next element
            int expectedNextElement = 1;

            //Initialize the min missing element with null
            int? minMissingElement = null;
             
            foreach(var item in itemsGreaterThanZero)
            {
                // if the current item == the expected next element, simply increment the expected element
                if (item == expectedNextElement)
                {
                    expectedNextElement++;
                } else if(item > expectedNextElement) // if the next element is greater than the expected next element, then the missing element has been found.
                {       
                    minMissingElement = expectedNextElement;
                    break;
                } 
            }

            return minMissingElement;
        }

        public static int? CalculateMinTimeFrogCanCrossRiver(int[] A, int X)
        {
            Dictionary<int, bool> leaves = new Dictionary<int, bool>();

            int? minTimeToCross = null;

            for (int i = 0; i < A.Length; i++)
            {
                //Add the leaves required to cross if they haven't already been added.
                if (!leaves.ContainsKey(A[i]) && A[i] <= X)
                {
                    leaves.Add(A[i], true);
                }

                //If all leaves have been added, set the min time to cross and break
                if (leaves.Count == X)
                {
                    minTimeToCross = i;

                    break;
                }
            }

            return minTimeToCross;
        }


        public static bool IsArrayPermutation(int[] A)
        {
            //Create hash to track each item in the array
            Dictionary<int, int> items = new Dictionary<int, int>();

            int maxItem = 0;
            bool maxCountGreaterThanOne = false;
            int currentItem;

            for (int i=0; i<A.Length; i++)
            {
                currentItem = A[i];
                
                //track the max item - if there are no missing elements, the max item value should equal the total number of elements
                maxItem = Math.Max(maxItem, currentItem);

                //check for duplicates
                if (items.ContainsKey(currentItem))
                {
                    items[currentItem]++;
                    maxCountGreaterThanOne = true;
                } else
                {
                    items.Add(currentItem, 1);
                }
            }

            //finally check if the array is a permutation
            if (items.Count == maxItem && !maxCountGreaterThanOne)
            {
                return true;
            } else
            {
                return false;
            }
        }
        
        public static int[] CalculateCounters(int[] A, int N)
        {
            int[] counters = new int[N];
            int maxCounter = 0;
            int counterValue = 0;

            for (int i=0; i<A.Length; i++)
            {
                for (int j=0; j< N; j++)
                {
                    counterValue = counters[j];
                    int x = j + 1;
                            
                    if (A[i] == (N + 1))
                    {
                        counterValue = maxCounter;
                    } else if( A[i] == x && 1 <= x && x <= N ){
                        counterValue ++;
                    }

                    maxCounter = Math.Max(maxCounter, counterValue);
                    counters[j] = counterValue;
                }
            }

            return counters;
        }
    }
}
