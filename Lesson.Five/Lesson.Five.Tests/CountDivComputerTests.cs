using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lesson.Five.Tests
{
    [TestClass]
    public class CountDivComputerTests
    {
        [TestMethod]
        public void Expect_Count_Div_Calculator_To_Return_Three()
        {
            Assert.AreEqual(3, CountDivComputer.Compute(6, 11, 2));
        }

        [TestMethod]
        public void Expect_Count_Div_Calulator_To_Return_Two()
        {
            Assert.AreEqual(2, CountDivComputer.Compute(3, 7, 2));
        }

        [TestMethod]
        public void Expect_Count_Div_Calulator_To_Return_Four()
        {
            Assert.AreEqual(4, CountDivComputer.Compute(21, 42, 7));
        }

        [TestMethod]
        public void Expect_Count_Div_Calculator_To_Return_Zero()
        {
            Assert.AreEqual(0, CountDivComputer.Compute(56, 65, 50));
        }
    }
}
