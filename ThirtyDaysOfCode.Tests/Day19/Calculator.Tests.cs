using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ThirtyDaysOfCode.Day19;

namespace ThirtyDaysOfCodeTests.Day19
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void DivisorSum_ReturnsCorrectSum()
        {
            // Arrange
            Calculator calc = new Calculator();
            int number = 6;
            int expectedResult = 12;

            // Act
            int actualResult = calc.divisorSum(number);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}