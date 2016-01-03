using System;
using System.Linq;
using System.Collections.Generic;

namespace BinaryGapCalculator
{
    public class Calculator
    {

        public static int Calculate(int n)
        {
            //convert the int to binary
            var result = Convert.ToString(n, 2).ToArray();

            //convert all items in the result array to binary items
            var allItems = result.Select((item, index) => new BinaryItem(item, index))
                    .ToList();

            //find all of the zeroes
            var zeroIndexes = allItems.Where(i => i.Item == 0).ToList();

            //if the binary array has no zeroes, no further work is required.
            if (zeroIndexes.Count == 0)
            {
                return 0;
            } else //loop through and find all of the binary gaps and calculate the length of each if there are any
            {
                int maxBinaryGapLength = 0;
                foreach (BinaryItem i in zeroIndexes)
                {
                    if (isBinaryGap(i.Index, allItems))
                    {
                        maxBinaryGapLength = getMaxInt(maxBinaryGapLength, calculateGapLengthForItemIndex(i.Index, result));
                    }
                }

                return maxBinaryGapLength;
            }
        }

        private static int getMaxInt(int int1, int int2)
        {
            return int1 > int2 ? int1 : int2;
        }

        private static int calculateGapLengthForItemIndex(int itemIndex, char[] items)
        {
            int gapLengthToTheRight = -1;
            int gapLengthToTheLeft = -1;

            //get the length to the right 
            for (int i = itemIndex; i < items.Length; i++)
            {
                if (items[i] ==  '0')
                {
                    gapLengthToTheRight++;
                }
                else
                {
                    break;
                }
            } 

            //get the length to the left
            for (int i = itemIndex; i >= 0; i--)
            {
                if (items[i] == '0')
                {
                    gapLengthToTheLeft++;
                } 
                else
                {
                    break;
                }
            }

            return gapLengthToTheLeft + gapLengthToTheRight + 1; //Adding one to account for the current index
        }

        private static bool isBinaryGap(int index, List<BinaryItem> items)
        {
            int maxToTheRight = items.Where(x => x.Index >= index).Max(y => y.Item);
            int maxToTheLeft = items.Where(x => x.Index <= index).Max(y => y.Item);

            //if there is a one on both sides of the index, then the index is part of a binary gap
            return maxToTheRight + maxToTheLeft == 2;
        }
    }

    public class BinaryItem
    {
        public int Item { get; set; }
        public int Index { get; set; }

        public BinaryItem(char item, int index)
        {
            this.Item = item == '1' ? 1 : 0;
            this.Index = index;
        }
    }
}
