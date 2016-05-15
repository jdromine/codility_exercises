using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson.Five
{
    // For a description of the problem see https://codility.com/programmers/task/genomic_range_query/
    public class GenomicRangeQueryComputer
    {
        private Dictionary<string, int> _nucleotideImpactFactors;

        public GenomicRangeQueryComputer()
        {
            _nucleotideImpactFactors = new Dictionary<string, int>();
            _nucleotideImpactFactors.Add("A", 1);
            _nucleotideImpactFactors.Add("C", 2);
            _nucleotideImpactFactors.Add("G", 3);
            _nucleotideImpactFactors.Add("T", 4);
        }

        public int[] Compute(string S, int[] P, int[] Q){
            int impactQueryStartingIndex = 0;
            int impactQueryEndingIndex = 0;
            int[] nucleotides = GetNucleotidesFromDNASequence(S);
            int[] impactQueryResults = new int[P.Length];

            for(int i=0; i<P.Length; i++)
            {
                impactQueryStartingIndex = P[i];
                impactQueryEndingIndex = Q[i];

                impactQueryResults[i] = GetMinimumImpactFactorForQuery(nucleotides, impactQueryStartingIndex, impactQueryEndingIndex);
            }

            return impactQueryResults;
        }

        private int GetMinimumImpactFactorForQuery(int[] nucleotides, int impactQueryStartingIndex, int impactQueryEndingIndex)
        {
            int minimumImpactQueryResult = nucleotides[impactQueryStartingIndex];

            for (int j = impactQueryStartingIndex; j <= impactQueryEndingIndex; j++)
            {
                minimumImpactQueryResult = Math.Min(minimumImpactQueryResult, nucleotides[j]);
            }

            return minimumImpactQueryResult;
        }


        private  int[] GetNucleotidesFromDNASequence(string sequence)
        {
            int[] nucleotides = new int[sequence.Length];

            for (int x = 0; x < sequence.Length; x++)
            {
                nucleotides[x] = GetNucleotideImpactFactor(sequence.Substring(x, 1));
            }

            return nucleotides;
        }

        private int GetNucleotideImpactFactor(string nucleotide)
        {
            int impactFactor = 0;

            _nucleotideImpactFactors.TryGetValue(nucleotide, out impactFactor);

            return impactFactor;
        }


    }
}
