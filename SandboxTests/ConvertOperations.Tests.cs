using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sandbox;

namespace SandboxTests
{
    [TestClass]
    public class ConvertOperationsTests
    {
        [TestMethod]
        public void NumberToBinary_IsConverted()
        {
            int number = 5422;
            string binaryExpected = "1010100101110";
            string binaryActual = "";

            binaryActual = ConvertOperations.Base10ToBinaryString(number);

            Assert.AreEqual(binaryExpected, binaryActual);
        }
    }
}
