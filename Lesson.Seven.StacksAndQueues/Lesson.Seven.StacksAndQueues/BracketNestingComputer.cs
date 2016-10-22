using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson.Seven.StacksAndQueues
{
    // For a description of the problem see https://codility.com/programmers/task/brackets/
    public class BracketNestingComputer
    {
        private Dictionary<char, char> _openingBrackets;
        private Dictionary<char, char> _closingBrackets;

        public BracketNestingComputer()
        {
            _openingBrackets = new Dictionary<char, char>();
            _closingBrackets = new Dictionary<char, char>();

            _openingBrackets.Add('(', ')');
            _openingBrackets.Add('[', ']');
            _openingBrackets.Add('{', '}');

            _closingBrackets.Add(')', '(');
            _closingBrackets.Add(']', '[');
            _closingBrackets.Add('}', '{');
        }

        public int Compute(string S)
        {
            bool hasProperNesting = true;

            char[] characters = S.ToCharArray();

            Stack<char> characterStack = new Stack<char>();

            for (int i = 0; i < characters.Length; i++)
            {
                char currentCharacter = characters[i];

                if (IsClosingBracket(currentCharacter))
                {
                    char expectedOpeningBracket;
                    bool hasOpeningBracket = false;

                    _closingBrackets.TryGetValue(currentCharacter, out expectedOpeningBracket);
                  
                    while (characterStack.Count != 0 && hasProperNesting == true && hasOpeningBracket == false)
                    {                     
                        if (!IsBracketCharacter(characterStack.Peek()))
                        {
                            characterStack.Pop(); // Non bracket characters can simply be removed
                        } else if (IsOpeningBracket(characterStack.Peek()))
                        {
                            if (characterStack.Peek() == expectedOpeningBracket)
                            {
                                hasOpeningBracket = true;
                                characterStack.Pop();
                            } else
                            {
                                hasProperNesting = false;
                            }
                        } else
                        {
                            hasProperNesting = false;
                        }
                    }
                }
                else if(characterStack.Count==0 && !IsOpeningBracket(currentCharacter))
                {
                    hasProperNesting = false;
                } 
                else
                {
                    characterStack.Push(currentCharacter);
                }

                if (!hasProperNesting)
                    break;

            }

            //Finally check if there were any characters without a closing bracket.
            if (characterStack.Count != 0)
                hasProperNesting = false;

            return hasProperNesting ? 1 : 0;
        }

        private bool IsBracketCharacter(char character)
        {
            return IsOpeningBracket(character) || IsClosingBracket(character);
        }

        private bool IsOpeningBracket(char character)
        {
            return _openingBrackets.ContainsKey(character);
        }

        private bool IsClosingBracket(char character)
        {
            return _closingBrackets.ContainsKey(character);
        }

    }

}
