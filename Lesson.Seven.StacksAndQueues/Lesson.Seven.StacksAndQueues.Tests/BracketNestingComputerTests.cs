using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lesson.Seven.StacksAndQueues.Tests
{
    [TestClass]
    public class BracketNestingComputerTests
    {
        [TestMethod]
        [TestCategory("BracketNestingComputer")]
        public void Compute_ReturnsOne_WhenProvidedAStringWithProperNesting()
        {
            BracketNestingComputer computer = new BracketNestingComputer();
            Assert.AreEqual(1, computer.Compute("{[()()]}"));
        }

        [TestMethod]
        [TestCategory("BracketNestingComputer")]
        public void Compute_ReturnsOne_WhenProvidedEmptyString()
        {
            BracketNestingComputer computer = new BracketNestingComputer();
            Assert.AreEqual(1, computer.Compute(""));
        }

        [TestMethod]
        [TestCategory("BracketNestingComputer")]
        public void Compute_ReturnsZero_WhenProvidedStringWithOneCharacter()
        {
            BracketNestingComputer computer = new BracketNestingComputer();
            Assert.AreEqual(0, computer.Compute("1"));
        }

        [TestMethod]
        [TestCategory("BracketNestingComputer")]
        public void Compute_ReturnsOne_WhenProvidedNestedStringWithNonBrackets()
        {
            BracketNestingComputer computer = new BracketNestingComputer();
            Assert.AreEqual(1, computer.Compute("{[(PPP)(CCC)]}"));
        }

        [TestMethod]
        [TestCategory("BracketNestingComputer")]
        public void Compute_ReturnsZero_WhenProvidedNonNestedString()
        {
            BracketNestingComputer computer = new BracketNestingComputer();
            Assert.AreEqual(0, computer.Compute("{[(PPP((CCC)]}"));
        }

        [TestMethod]
        [TestCategory("BracketNestingComputer")]
        public void Compute_ReturnsZero_WhenProvidedAllOpeningBrackets()
        {
            BracketNestingComputer computer = new BracketNestingComputer();
            Assert.AreEqual(0, computer.Compute("{[(((("));
        }
    }
}
