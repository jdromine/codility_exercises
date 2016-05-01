using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lesson.Two.Tests
{
    [TestClass]
    public class OddOccurrencesInArrayComputerTests
    {
        [TestMethod]
        public void Expect_Calculate_to_Return_7()
        {
            int result = OddOccurrencesInArrayComputer.Compute(new int[] { 9, 3, 9, 3, 9, 7, 9 });
            Assert.AreEqual(7, result);
        }
    }
}
