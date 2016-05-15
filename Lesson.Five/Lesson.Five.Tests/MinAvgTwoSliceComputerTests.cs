﻿using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lesson.Five.Tests
{
    /// <summary>
    /// Summary description for MinAvgTwoSliceComputerTests
    /// </summary>
    [TestClass]
    public class MinAvgTwoSliceComputerTests
    {
        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod TestCategory("MinAvgTwoSlice")]
        public void Expect_Computer_to_Compute_One_For_Base_Case()
        {
            Assert.AreEqual(1, MinAvgTwoSliceComputer.Compute(new int[] { 4, 2, 2, 5, 1, 5, 8 }, 7));
        }

        [TestMethod TestCategory("MinAvgTwoSlice")]
        [ExpectedException(typeof(System.ArgumentException))]
        public void Expect_Exception_When_Array_With_One_Int_is_Provided()
        {
            MinAvgTwoSliceComputer.Compute(new int[] { 4 }, 1);
        }
    }
}
