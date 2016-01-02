using System;
using System.Linq;

namespace BinaryMapCalculator
{
    public class Calculator
    {

        public static int Calculate(int n)
        {
            //convert the int to binary
            var result = Convert.ToString(n, 2).ToArray();

            //find all of the zeroes
            var zeroIndexes = result.Select((item, index) => new BinaryMapItem(item, index))
                    .Where(i => i.Item == '0').ToList();

            //if the binary array has no zeroes, no further work is required.
            if (zeroIndexes.Count == 0)
            {
                return 0;
            } else //loop through and find all of the binary maps and calculate the length if there are any
            {
                int maxBinaryMapLength = 0;
                foreach (BinaryMapItem i in zeroIndexes)
                {
                    if (isBinaryMap(i.Index, result))
                    {
                        maxBinaryMapLength = getMaxInt(maxBinaryMapLength, calculateMapLengthForItemIndex(i.Index, result));
                    }
                }

                return maxBinaryMapLength;
            }
        }

        private static int getMaxInt(int int1, int int2)
        {
            return int1 > int2 ? int1 : int2;
        }

        private static int calculateMapLengthForItemIndex(int itemIndex, char[] items)
        {
            int mapLengthToTheRight = -1;
            int mapLengthToTheLeft = -1;

            //get the length to the right start with the index passed in which will set the length to zero
            for (int i = itemIndex; i < items.Length; i++)
            {
                if (items[i] == '0')
                {
                    mapLengthToTheRight++;
                }
                else
                {
                    break;
                }
            } 

            //get the length to the left startng with the index passed in which will set the length to zero
            for (int i = itemIndex; i >= 0; i--)
            {
                if (items[i] == '0')
                {
                    mapLengthToTheLeft++;
                } 
                else
                {
                    break;
                }
            }

            return mapLengthToTheLeft + mapLengthToTheRight + 1;
        }

        private static bool isBinaryMap(int index, char[] items)
        {
            int maxToTheRight = 0;
            int maxToTheLeft = 0;

            for (int i = index + 1; i < items.Length; i++)
            {
                int value = items[i] == '1' ? 1 : 0;
                maxToTheRight = getMaxInt(maxToTheRight, value);
            }

            for (int i = index -1; i >= 0; i--)
            {
                int value = items[i] == '1' ? 1 : 0;
                maxToTheLeft = getMaxInt(maxToTheLeft, value);
            }

            return maxToTheRight + maxToTheLeft == 2;
        }
    }

    public class BinaryMapItem
    {
        public char Item { get; set; }
        public int Index { get; set; }

        public BinaryMapItem(char item, int index)
        {
            this.Item = item;
            this.Index = index;
        }
    }
}
