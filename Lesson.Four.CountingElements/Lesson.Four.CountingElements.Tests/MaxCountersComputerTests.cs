using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lesson.Four.CountingElements.Tests
{
    [TestClass]
    public class MaxCountersComputerTests
    {
        [TestMethod]
        public void Expect_MaxCounters_To_Return_Correct_Set()
        {
            int[] result = MaxCountersComputer.Compute(new int[] { 3, 4, 4, 6, 1, 4, 4 }, 5);
            Assert.AreEqual(3, result[0]);
            Assert.AreEqual(2, result[1]);
            Assert.AreEqual(2, result[2]);
            Assert.AreEqual(4, result[3]);
            Assert.AreEqual(2, result[4]);

        }
    }
}
