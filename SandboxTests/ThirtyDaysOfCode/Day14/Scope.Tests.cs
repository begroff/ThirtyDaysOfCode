using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sandbox.ThirtyDaysOfCode;
using System.IO;
using System;

namespace SandboxTests
{
    [TestClass]
    public class ScopeTests
    {
        [TestMethod]
        public void CalculateDifference()
        {
            // Arrange
            int[] numbers = { 8, 19, 3, 2, 7 };
            int expectedDiff = 17;
            Difference diff = new Difference(numbers);

            // Act
            diff.ComputeDifference();

            // Assert
            Assert.AreEqual(expectedDiff, diff.maximumDifference);
        }
    }
}