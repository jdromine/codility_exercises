using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BinaryMapCalculator;

namespace BinaryMapTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Expect_15_to_Return_Zero()
        {
            Assert.AreEqual(0, Calculator.Calculate(15));
        }

        [TestMethod]
        public void Expect_20_to_Return_One()
        {
            Assert.AreEqual(1, Calculator.Calculate(20));
        }

        [TestMethod]
        public void Expect_1041_to_Return_Five()
        {
            Assert.AreEqual(5, Calculator.Calculate(1041));
        }
    }

}
