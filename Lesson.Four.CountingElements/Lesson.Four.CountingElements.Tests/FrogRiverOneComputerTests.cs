using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lesson.Four.CountingElements.Tests
{
    [TestClass]
    public class FrogRiverOneComputerTests
    {
        [TestMethod]
        public void Expect_FrogRiverOneComputer_To_Compute_Six()
        {
            Assert.AreEqual(6, FrogRiverOneComputer.Compute(new int[] { 1, 3, 1, 4, 2, 3, 5, 4 }, 5));
        }

        [TestMethod]
        public void Expect_FrogRiverOneComputer_To_Compute_NegativeOne_When_Cant_Cross()
        {
            Assert.AreEqual(-1, FrogRiverOneComputer.Compute(new int[] { 1, 3, 1, 4, 2, 3, 2, 4 }, 5));
        }

    }
}
