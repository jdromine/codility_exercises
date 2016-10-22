using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lesson.Seven.StacksAndQueues.Tests
{
    [TestClass]
    public class NestingComputerTests
    {
        [TestMethod]
        [TestCategory("NestingComputer")]
        public void Compute_ShouldReturnOne_WhenProvidedExampleCase()
        {
            Assert.AreEqual(1, NestingComputer.Compute("(()(())())"));
        }

        [TestMethod]
        [TestCategory("NestingComputer")]
        public void Compute_ShouldReturnZero_WhenProvidedStringWithOddNumberOfCharacters()
        {
            Assert.AreEqual(0, NestingComputer.Compute("(()(())()"));
        }

        [TestMethod]
        [TestCategory("NestingComputer")]
        public void Compute_ShouldReturnZero_WhenProvidedUnnestedString()
        {
            Assert.AreEqual(0, NestingComputer.Compute("()()())(()"));
        }

        [TestMethod]
        [TestCategory("NestingComputer")]
        public void Compute_ShouldReturnOne_WhenProvidedNestedString()
        {
            Assert.AreEqual(1, NestingComputer.Compute("((((()))))"));
        }
    }
}
