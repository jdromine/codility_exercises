using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _02.OddOccurrencesInArray;

namespace OddOccurrencesInArrayTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Expect_Calculate_to_Return_7()
        {
            int result = Calculator.Calculate(new int[] { 9, 3, 9, 3, 9, 7, 9 });
            Assert.AreEqual(7, result);
        }
    }
}
