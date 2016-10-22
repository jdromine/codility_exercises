using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lesson.Six.Sorting.Tests
{
    [TestClass]
    public class NumberOfIntersectingDiscsComputerTests
    {
        [TestMethod]
        [TestCategory("NumberOfIntersectingDiscsComputer")]
        public void Expect_Base_Case_to_Return_Eleven()
        {
            Assert.AreEqual(11,NumberOfIntersectingDiscsComputer.Compute(new int[] { 1, 5, 2, 1, 4, 0 }, 10000000));
        }

        [TestMethod]
        [TestCategory("NumberOfIntersectingDiscsComputer")]
        public void Expect_Computer_to_Return_NegativeOne_When_Exceeding_Max()
        {
            Assert.AreEqual(-1, NumberOfIntersectingDiscsComputer.Compute(new int[] { 1, 5, 2, 1, 4, 0 }, 10));
        }
    }
}
