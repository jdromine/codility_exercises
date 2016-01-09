using System;
using System.Linq;
using System.Collections.Generic;

namespace BinaryGapCalculator
{
    public class Calculator
    {

        public static int Calculate(int n)
        {
            int maxBinaryGapLength = 0;
            int currentBinaryGapLength = 0;

            //convert the int to binary
            var characters = Convert.ToString(n, 2).ToArray();

            for (int i = 0; i < characters.Length; i++)
            {
                if (characters[i] == '0')
                { 
                    //Increment the current binary gap
                    if (currentBinaryGapLength > 0)
                    {
                        currentBinaryGapLength++;
                    }
                    //Initialize a new binary gap
                    else
                    {
                        if (i > 0 && characters[i - 1] == '1')
                        {
                            currentBinaryGapLength = 1;
                        }
                    }
                }
                //update the max and reset the current binary gap
                else
                {
                    maxBinaryGapLength = Math.Max(maxBinaryGapLength, currentBinaryGapLength);
                    currentBinaryGapLength = 0;
                }
            }
            return maxBinaryGapLength;
        }
    }
}
