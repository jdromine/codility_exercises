using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lesson.Three.Tests
{
    [TestClass]
    public class TapeEquilibriumComputerTests
    {
        [TestMethod]
        public void Expect_TapeEquilibriumComputer_To_Return_One()
        {
            Assert.AreEqual(1, TapeEquilibriumComputer.Compute(new int[] { 3, 1, 2, 4, 3 }));
        }
    }
}
