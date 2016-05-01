using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lesson.Five.Tests
{
    /// <summary>
    /// Summary description for PassingCarsComputerTests
    /// </summary>
    [TestClass]
    public class PassingCarsComputerTests
    {
        [TestMethod]
        public void Expect_PassingCarsComputer_To_Compute_Zero_When_Empty_Array()
        {
            Assert.AreEqual(0, PassingCarsComputer.Compute(new int[] { }));
        }

        [TestMethod]
        public void Expect_PassingCarsComputer_To_Compute_Five_WhenComputingBaseCase()
        {
            Assert.AreEqual(5, PassingCarsComputer.Compute(new int[] { 0, 1, 0, 1, 1 }));
        }
    }
}
