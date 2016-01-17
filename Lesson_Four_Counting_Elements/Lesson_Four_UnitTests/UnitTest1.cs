using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lesson_Four_Counting_Elements;

namespace Lesson_Four_UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Expect_Missing_Integer_Calculator_To_Return_Five()
        {
            Assert.AreEqual(5, Calculator.CalculateMissingMinimumPositiveInteger(new int[] { 1, 3, 6, 4, 1, 2 }));
        }

        [TestMethod]
        public void Expect_Negative_Missing_Integer_To_Be_Skipped()
        {
            Assert.AreEqual(5, Calculator.CalculateMissingMinimumPositiveInteger(new int[] {-3,-2,0, 1, 3, 6, 4, 1, 2 }));
        }

        [TestMethod]
        public void Expect_No_Missing_Integer_To_Be_Null()
        {
            Assert.IsNull(Calculator.CalculateMissingMinimumPositiveInteger(new int[] { -3, -2, -1, 0, 1, 3, 6, 5, 4, 1, 2 }));
        }

        [TestMethod]
        public void Expect_MinTimeToCross_Calculator_To_Be_Six()
        {
            Assert.AreEqual(6, Calculator.CalculateMinTimeFrogCanCrossRiver(new int[] { 1,3,1,4,2,3,5,4}, 5));
        }

        [TestMethod]
        public void Expect_MinTimeToCross_Calculator_To_Be_NULL_When_Cant_Cross()
        {
            Assert.IsNull(Calculator.CalculateMinTimeFrogCanCrossRiver(new int[] { 1, 3, 1, 4, 2, 3, 2, 4 }, 5));
        }

        [TestMethod]
        public void Expect_ArrayPermutation_To_Be_True()
        {
            Assert.IsTrue(Calculator.IsArrayPermutation(new int[] { 1, 2, 3, 4 }));
        }

        [TestMethod]
        public void Expect_ArrayPermutation_WithMissingElement_To_Be_False()
        {
            Assert.IsFalse(Calculator.IsArrayPermutation(new int[] { 1, 3, 4 }));
        }

        [TestMethod]
        public void Expect_ArrayPermutation_WithDuplicateElements_To_Be_False()
        {
            Assert.IsFalse(Calculator.IsArrayPermutation(new int[] { 1, 2, 3, 4, 4 }));
        }
    }
}
