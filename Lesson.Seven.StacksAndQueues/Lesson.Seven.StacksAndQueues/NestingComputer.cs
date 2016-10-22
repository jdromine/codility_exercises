using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson.Seven.StacksAndQueues
{
    public class NestingComputer
    {

        public static int Compute(string S){
            bool hasProperNesting = true;

            string workingString = S;

            if(S.Length % 2 != 0){
                hasProperNesting = false;
            }

            while (workingString.Length != 0 && hasProperNesting)
            {
                int middlePosition = workingString.Length / 2;
                string currentCharacter = workingString.Substring(middlePosition, 1);

                if (IsOpeningCharacter(currentCharacter))
                {
                    hasProperNesting = IsClosingCharacter(workingString.Substring(middlePosition + 1, 1));
                    workingString = workingString.Remove(middlePosition, 2);
                } else if(IsClosingCharacter(currentCharacter)){
                    hasProperNesting = IsOpeningCharacter(workingString.Substring(middlePosition - 1, 1));
                    workingString = workingString.Remove(middlePosition - 1, 2);
                }
                else
                {
                    hasProperNesting = false;
                }                
            }

            return hasProperNesting ? 1 : 0;
        }

        private static bool IsOpeningCharacter(string character)
        {
            return character == "(";
        }

        private static bool IsClosingCharacter(string character)
        {
            return character == ")";
        }

    }
}
