using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lesson.Six.Sorting.Tests
{
    [TestClass]
    public class TriangleComputerTests
    {
        [TestMethod]
        [TestCategory("TriangleComputer")]
        public void Expect_TriangleComputer_To_Compute_One_ForBaseCase  ()
        {
            Assert.AreEqual(1, TriangleComputer.Compute(new int[] {10,5,8}));
        }

        [TestMethod]
        [TestCategory("TriangleComputer")]
        public void Expect_TriangleComputer_To_Compute_Zero_ForBaseCase()
        {
            Assert.AreEqual(0, TriangleComputer.Compute(new int[] { 10, 50, 5}));
        }

        [TestMethod]
        [TestCategory("TriangleComputer")]
        public void Expect_TriangleComputer_To_Compute_Zero_When_ArrayLength_LessThan_Three()
        {
            Assert.AreEqual(0, TriangleComputer.Compute(new int[] { 10}));
        }
    }
}
