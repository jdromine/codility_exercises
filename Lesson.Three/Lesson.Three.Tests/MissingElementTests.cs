using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lesson.Three.Tests
{
    [TestClass]
    public class MissingElementTests
    {
        [TestMethod]
        public void Expect_MissingElementComputer_To_Return_Four()
        {
            Assert.AreEqual(4, MissingElementComputer.Compute(new int[] { 2, 3, 1, 5 }));
        }
    }
}
