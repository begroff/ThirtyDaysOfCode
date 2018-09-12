using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sandbox;

namespace SandboxTests
{
    [TestClass]
    public class HourglassTests
    {
        [TestMethod]
        public void Hourglass_Test()
        {
            int actualLargestSum;
            int expectedLargestSum = 19;
            Hourglass testArray = new Hourglass();

            actualLargestSum = testArray.calculateLargestHourglassSum();

            Assert.AreEqual(expectedLargestSum, actualLargestSum);
        }

    }
}