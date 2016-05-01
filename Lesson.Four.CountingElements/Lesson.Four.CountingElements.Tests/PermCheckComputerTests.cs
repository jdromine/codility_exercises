using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lesson.Four.CountingElements.Tests
{
    [TestClass]
    public class PermCheckComputerTests
    {
        [TestMethod]
        public void Expect_PermCheckComputer_To_Compute_True()
        {
            Assert.IsTrue(PermCheckComputer.Compute(new int[] { 1, 2, 3, 4 }));
        }

        [TestMethod]
        public void Expect_PermCheckComputer_WhenProvided_ArrayWithMissingElement_To_Compute_False()
        {
            Assert.IsFalse(PermCheckComputer.Compute(new int[] { 1, 3, 4 }));
        }

        [TestMethod]
        public void Expect_PermCheckComputer_WhenProvided_ArrayWithDuplicateElements_To_Compute_False()
        {
            Assert.IsFalse(PermCheckComputer.Compute(new int[] { 1, 2, 3, 4, 4 }));
        }
    }
}
