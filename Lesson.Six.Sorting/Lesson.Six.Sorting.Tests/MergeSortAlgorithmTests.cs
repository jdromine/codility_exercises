using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lesson.Six.Sorting.Tests
{
    [TestClass]
    public class MergeSortAlgorithmTests
    {
        [TestMethod]
        [TestCategory("MergeSort")]
        public void Expect_MergeSort_To_SortArray()
        {
            int[] unsortedArray = new int[] { 5, 2, 3, 4, 1 };

            unsortedArray = MergeSortAlgorithm.Sort(unsortedArray);

            Assert.AreEqual(1, unsortedArray[0]);
            Assert.AreEqual(2, unsortedArray[1]);
            Assert.AreEqual(3, unsortedArray[2]);
            Assert.AreEqual(4, unsortedArray[3]);
            Assert.AreEqual(5, unsortedArray[4]);
        }
    }
}
