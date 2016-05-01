using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lesson_Five_Prefix_Sums;

namespace Lesson_Five_UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Expect_Count_Div_Calculator_To_Return_Three()
        {
            Assert.AreEqual(3, Calculator.CalculateCountDiv(6, 11, 2));
        }

        [TestMethod]
        public void Expect_Count_Div_Calulator_To_Return_Two()
        {
            Assert.AreEqual(2, Calculator.CalculateCountDiv(3, 7, 2));
        }

        [TestMethod]
        public void Expect_Count_Div_Calulator_To_Return_Four()
        {
            Assert.AreEqual(4, Calculator.CalculateCountDiv(21, 42, 7));
        }

        [TestMethod]
        public void Expect_Count_Div_Calculator_To_Return_Zero()
        {
            Assert.AreEqual(0, Calculator.CalculateCountDiv(56, 65, 50));
        }
    }
}
