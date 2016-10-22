using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lesson.Six.Sorting.Tests
{
    [TestClass]
    public class SelectionSortAlgorithmTests
    {
        [TestMethod]
        [TestCategory("SelectionSort")]
        public void Expect_SelectionSort_to_SortArray()
        {
            int[] unsortedArray = new int[] { 5, 2, 3, 4, 1 };

            SelectionSortAlgorithm.Sort(unsortedArray);

            Assert.AreEqual(1, unsortedArray[0]);
            Assert.AreEqual(2, unsortedArray[1]);
            Assert.AreEqual(3, unsortedArray[2]);
            Assert.AreEqual(4, unsortedArray[3]);
            Assert.AreEqual(5, unsortedArray[4]);
        }
    }
}
