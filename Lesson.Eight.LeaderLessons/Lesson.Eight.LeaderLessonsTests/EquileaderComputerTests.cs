using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lesson.Eight.LeaderLessons;

namespace Lesson.Eight.LeaderLessonsTests
{
    [TestClass]
    public class EquiLeaderComputerTests
    {
        [TestMethod]
        [TestCategory("EquiLeader")]
        public void Compute_ShouldReturnTwo_WhenProvidedExampleCase()
        {
            Assert.AreEqual(2, EquiLeaderComputer.Compute(new int[] {4,3,4,4,4,2 }));
        }
    }
}
