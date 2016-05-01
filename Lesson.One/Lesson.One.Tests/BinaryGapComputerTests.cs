using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lesson.One.Tests
{
    [TestClass]
    public class BinaryGapComputerTests
    {
        [TestMethod]
        public void Expect_15_to_Return_Zero()
        {
            Assert.AreEqual(0, BinaryGapComputer.Compute(15));
        }

        [TestMethod]
        public void Expect_20_to_Return_One()
        {
            Assert.AreEqual(1, BinaryGapComputer.Compute(20));
        }

        [TestMethod]
        public void Expect_1041_to_Return_Five()
        {
            Assert.AreEqual(5, BinaryGapComputer.Compute(1041));
        }
    }
}
