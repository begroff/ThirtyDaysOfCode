using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sandbox.ThirtyDaysOfCode;

namespace SandboxTests
{
    [TestClass]
    public class HourglassTests
    {
        [TestMethod]
        public void Hourglass_Test()
        {
            int actualLargestSum;
            int expectedLargestSum = -6;
            Hourglass hourglassTest = new Hourglass();

            actualLargestSum = hourglassTest.CalculateLargestHourglassSum();

            Assert.AreEqual(expectedLargestSum, actualLargestSum);
        }

    }
}