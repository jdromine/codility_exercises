using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lesson.Four.CountingElements.Tests
{
    [TestClass]
    public class MissingIntegerComputerTests
    {
        [TestMethod]
        public void Expect_MissingIntegerComputer_To_Compute_Five()
        {
            Assert.AreEqual(5, MissingIntegerComputer.Compute(new int[] { 1, 3, 6, 4, 1, 2 }));
        }

        [TestMethod]
        public void Expect_Negative_MissingIntegerComputer_To_Compute_Skipped()
        {
            Assert.AreEqual(5, MissingIntegerComputer.Compute(new int[] { -3, -2, 0, 1, 3, 6, 4, 1, 2 }));
        }

        [TestMethod]
        public void Expect_No_MissingIntegerComputer_To_Compute_Null()
        {
            Assert.IsNull(MissingIntegerComputer.Compute(new int[] { -3, -2, -1, 0, 1, 3, 6, 5, 4, 1, 2 }));
        }
    }
}
