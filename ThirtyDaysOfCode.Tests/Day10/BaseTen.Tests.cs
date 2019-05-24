using Microsoft.VisualStudio.TestTools.UnitTesting;
using ThirtyDaysOfCode.Day10;

namespace ThirtyDaysOfCodeTests.Day10
{
    [TestClass]
    public class BaseTenTests
    {
        [TestMethod]
        public void BaseTenToBinary_IsConverted()
        {
            int number = 5422;
            string binaryExpected = "1010100101110";
            string binaryActual = "";

            binaryActual = BaseTen.ToBinaryString(number);

            Assert.AreEqual(binaryExpected, binaryActual);
        }
    }
}
