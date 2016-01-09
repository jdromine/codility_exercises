using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lesson._03.TimeComplexity;

namespace Lesson3UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Expect_TapeEquilibriumCalculator_To_Return_One()
        {
            Assert.AreEqual(1, Calculator.CalculateTapeEquilibrium(new int[] {3,1,2,4,3}));
        }

        [TestMethod]
        public void Expect_MissingElementCalculator_To_Return_Four()
        {
            Assert.AreEqual(4,Calculator.CalculateMissingElement(new int[] {2,3,1,5}));
        }
    }
}
