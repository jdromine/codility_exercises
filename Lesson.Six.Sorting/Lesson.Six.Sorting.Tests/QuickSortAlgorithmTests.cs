using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lesson.Six.Sorting.Tests
{
    [TestClass]
    public class QuickSortAlgorithmTests
    {
        [TestMethod]
        [TestCategory("QuickSort")]
        public void Expect_QuickSort_To_Sort_SimpleUnsortedArray()
        {
            int[] unsortedArray = new int[] { 5, 2, 3, 4, 1 };

            unsortedArray = QuickSortAlgorithm.Sort(unsortedArray);

            Assert.AreEqual(1, unsortedArray[0]);
            Assert.AreEqual(2, unsortedArray[1]);
            Assert.AreEqual(3, unsortedArray[2]);
            Assert.AreEqual(4, unsortedArray[3]);
            Assert.AreEqual(5, unsortedArray[4]);
        }


        [TestMethod]
        [TestCategory("QuickSort")]
        public void Expect_QuickSort_To_Sort_SortedArray()
        {
            int[] unsortedArray = new int[] { 1, 2, 3, 4, 5 };

            unsortedArray = QuickSortAlgorithm.Sort(unsortedArray);

            Assert.AreEqual(1, unsortedArray[0]);
            Assert.AreEqual(2, unsortedArray[1]);
            Assert.AreEqual(3, unsortedArray[2]);
            Assert.AreEqual(4, unsortedArray[3]);
            Assert.AreEqual(5, unsortedArray[4]);
        }


        [TestMethod]
        [TestCategory("QuickSort")]
        public void Expect_QuickSort_To_Sort_LargerUnSortedArray()
        {
            int[] unsortedArray = new int[] { 100, 90, 80, 70, 60, 50, 40, 30, 20, 10, 5, 4, 3, 2, 1};

            unsortedArray = QuickSortAlgorithm.Sort(unsortedArray);

            Assert.AreEqual(1, unsortedArray[0]);
            Assert.AreEqual(2, unsortedArray[1]);
            Assert.AreEqual(3, unsortedArray[2]);
            Assert.AreEqual(4, unsortedArray[3]);
            Assert.AreEqual(5, unsortedArray[4]);
        }
    }
}
