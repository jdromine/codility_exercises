using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lesson.Five.Tests
{
    [TestClass]
    public class GenomicRangeQueryComputerTests
    {
        [TestMethod]
        [TestCategory("GenomicRangeQuery")]
        public void Expect_GenomicRangeQueryComputer_To_Compute_2_4_1_When_Provided_Base_Case()
        {
            GenomicRangeQueryComputer genomicRangeQueryComputer = new GenomicRangeQueryComputer();

            int[] result = genomicRangeQueryComputer.Compute("CAGCCTA", new int[] { 2, 5, 0 }, new int[] { 4, 5, 6 });

            Assert.AreEqual(2, result[0]);
            Assert.AreEqual(4, result[1]);
            Assert.AreEqual(1, result[2]);
        }

        [TestMethod]
        [TestCategory("GenomicRangeQuery")]
        public void Expect_GenomicRangeQueryComputer_To_Compute_ZeroImpactFactor_ForNucleotideNotInACGT()
        {
            GenomicRangeQueryComputer genomicRangeQueryComputer = new GenomicRangeQueryComputer();

            int[] result = genomicRangeQueryComputer.Compute("CAGCCTAB", new int[] { 2, 5, 0 }, new int[] { 4, 5, 7 });

            Assert.AreEqual(2, result[0]);
            Assert.AreEqual(4, result[1]);
            Assert.AreEqual(0, result[2]);
        }
    }
}
