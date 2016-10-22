using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lesson.Six.Sorting.Tests
{
    [TestClass]
    public class DistinctValueCountComputerTests
    {
        [TestMethod]
        [TestCategory("DistinctValueComputer")]
        public void Expect_DistinctValueComputer_To_Return_Zero_When_Provided_Emtpy_Array()
        {
            Assert.AreEqual(0,DistinctValueCountComputer.Compute(new int[] { }));
        }


        [TestMethod]
        [TestCategory("DistinctValueComputer")]
        public void Expect_DistinctValueComputer_To_Return_One_When_Provided_ArrayWithOneValue()
        {
            Assert.AreEqual(1, DistinctValueCountComputer.Compute(new int[] {1,1,1,1}));
        }

        [TestMethod]
        [TestCategory("DistinctValueComputer")]
        public void Expect_DistinctValueComputer_To_Return_Three()
        {
            Assert.AreEqual(3, DistinctValueCountComputer.Compute(new int[] { 1,2,3}));
        }
    }
}
