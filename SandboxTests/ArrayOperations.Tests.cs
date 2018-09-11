using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sandbox;

namespace SandboxTests
{
    [TestClass]
    public class ArrayOperationsTests
    {
        [TestMethod]
        public void Array_IsReversed()
        {
            int[] actual = { 4, 7, 8, 9 };
            int[] reversed = { 9, 8, 7, 4 };
            int[] expected = new int[4];

            expected = (int[])ArrayOperations.Reverse(actual);

            CollectionAssert.AreEqual(expected, reversed);
        }
    }
}
