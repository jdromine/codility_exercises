using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lesson.Three.Tests
{
    [TestClass]
    public class FrogJumpComputerTests
    {
        [TestMethod]
        public void Expect_FrogJumpComputer_To_Return_Three()
        {
            Assert.AreEqual(3, FrogJumpComputer.Compute(10, 85, 30));
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException))]
        public void Expect_ArgumentException_When_DistanceEqualsZero()
        {
            FrogJumpComputer.Compute(10, 85, 0);
        }

    }
}
