using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson.Eight.LeaderLessons
{
    public class LeaderUtilities
    {
        private static int GetLeaderCandidateFromArray(int[] array)
        {
            Stack<int> leaderCandidates = new Stack<int>();

            for (int i = 0; i < array.Length; i++)
            {
                if (leaderCandidates.Count == 0)
                {
                    leaderCandidates.Push(array[i]);
                }
                else if (leaderCandidates.Peek() != array[i])
                {
                    leaderCandidates.Pop();
                }
                else
                {
                    leaderCandidates.Push(array[i]);
                }
            }

            if (leaderCandidates.Count == 0)
            {
                return -1;
            }
            else
            {
                return leaderCandidates.Pop();
            }
        }

        private static bool IsLeader(int[] array, int leaderCandidate)
        {
            int countOfOccurrences = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == leaderCandidate)
                {
                    countOfOccurrences++;
                }
            }

            return countOfOccurrences > array.Length / 2;
        }

        public static int GetLeaderFromArray(int[] array)
        {
            int leaderCandidate = GetLeaderCandidateFromArray(array);

            if (IsLeader(array, leaderCandidate))
            {
                return leaderCandidate;
            }
            else
            {
                return -1;
            }
        }
    }
}
