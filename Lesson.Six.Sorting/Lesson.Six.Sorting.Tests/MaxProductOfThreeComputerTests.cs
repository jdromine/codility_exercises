using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lesson.Six.Sorting.Tests
{
    /// <summary>
    /// Summary description for MaxProductOfThreeComputerTests
    /// </summary>
    [TestClass]
    public class MaxProductOfThreeComputerTests
    {

        [TestMethod]
        [TestCategory("MaxProductOfThreeComputer")]
        public void Expect_Computer_to_Handle_Negatives_and_Positives()
        {
            Assert.AreEqual(60, MaxProductOfThreeComputer.Compute(new int[] { -3, 1, 2, -2, 5, 6 }));
        }


        [TestMethod TestCategory("MaxProductOfThreeComputer")]
        [ExpectedException(typeof(System.ArgumentException))]
        public void Expect_Exception_When_Array_With_Less_than_Three_Ints_is_Provided()
        {
            MaxProductOfThreeComputer.Compute(new int[] { 4, 2 });
        }
    }
}
