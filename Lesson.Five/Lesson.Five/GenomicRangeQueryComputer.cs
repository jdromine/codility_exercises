using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson.Five
{
    public class GenomicRangeQueryComputer
    {
        public static int[] Compute(string S, int[] P, int[] Q){
            int queryStart = 0;
            int queryEnd = 0;
            int[] nucleotides = GetNucleotidesFromDNASequence(S);
            int[] queryResults = new int[P.Length];

            for(int i=0; i<P.Length; i++)
            {
                queryStart = P[i];
                queryEnd = Q[i];

                int queryResult = nucleotides[queryStart];

                for (int j=queryStart; j <= queryEnd; j++)
                {
                    queryResult = Math.Min(queryResult, nucleotides[j]);
                }

                queryResults[i] = queryResult;
            }

            return queryResults;
        }

        private static int[] GetNucleotidesFromDNASequence(string sequence)
        {
            int[] nucleotides = new int[sequence.Length];

            for (int x = 0; x < sequence.Length; x++)
            {
                nucleotides[x] = GetNucleotideImpactFactor(sequence.Substring(x, 1));
            }

            return nucleotides;
        }

        private static int GetNucleotideImpactFactor(string nucleotide)
        {
            int impactFactor = 0;
            switch  (nucleotide) {
                case "A":
                    impactFactor = 1;
                    break;
                case "C":
                    impactFactor = 2;
                    break;
                case "G":
                    impactFactor = 3;
                    break;
                case "T":
                    impactFactor = 4;
                    break;
                default:
                    impactFactor = 0;
                    break;
            }

            return impactFactor;
        }
    }
}
