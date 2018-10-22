using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sandbox.ThirtyDaysOfCode;
using System;

namespace SandboxTests.ThirtyDaysOfCode
{
    [TestClass]
    public class ConvertStringTests
    {
        [TestMethod]
        public void TestMethodName()
        {
            // Arrange
            string nonIntegerString = "za";
            string actualOutput = "";
            string expectedOutput = "Bad String";

            // Act
            try
            {
                ConvertString.ToInteger(nonIntegerString);
            }
            catch (Exception ex)
            {
                actualOutput = ex.Message;
            }

            // Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }

    }
}