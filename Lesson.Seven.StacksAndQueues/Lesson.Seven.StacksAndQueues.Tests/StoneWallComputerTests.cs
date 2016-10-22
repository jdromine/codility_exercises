using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lesson.Seven.StacksAndQueues.Tests
{
    [TestClass]
    public class StoneWallComputerTests
    {
        [TestMethod]
        [TestCategory("StoneWallComputer")]
        public void Compute_ReturnsSeven_WhenProvidedExampleCaseInProblem()
        {
            Assert.AreEqual(7, StoneWallComputer.Compute(new int[]{ 8, 8, 5, 7, 9, 8, 7, 4,8}));
        }

        [TestMethod]
        [TestCategory("StoneWallComputer")]
        public void Compute_ReturnsArrayLength_WhenProvidedNoReusableStones()
        {
            Assert.AreEqual(8, StoneWallComputer.Compute(new int[] {1,2,3,4,5,6,7,8}));
        }

        [TestMethod]
        [TestCategory("StoneWallComputer")]
        public void Compute_ReturnsOne_WhenProvidedOnlyOneInt()
        {
            Assert.AreEqual(1, StoneWallComputer.Compute(new int[] { 1 }));
        }

        [TestMethod]
        [TestCategory("StoneWallComputer")]
        public void Compute_ReturnsZero_WhenProvidedEmptyArray()
        {
            Assert.AreEqual(0, StoneWallComputer.Compute(new int[] { }));
        }
    }
}
