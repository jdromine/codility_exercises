using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lesson.Seven.StacksAndQueues.Tests
{
    [TestClass]
    public class AliveFishComputerTests
    {
        [TestMethod]
        [TestCategory("AliveFishComputer")]
        public void Compute_ReturnsTwo_WhenProvidedLessonExample()
        {
            Assert.AreEqual(2,AliveFishComputer.Compute(new int[] { 4, 3, 2, 1, 5 }, new int[] { 0, 1, 0, 0, 0 }));

        }

        [TestMethod]
        [TestCategory("AliveFishComputer")]
        public void Compute_ReturnsOne_WhenProvidedArrayWithOneValue()
        {
            Assert.AreEqual(1, AliveFishComputer.Compute(new int[] { 4}, new int[] { 0}));

        }
    }
}
