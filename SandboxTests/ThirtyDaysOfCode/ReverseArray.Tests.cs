using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sandbox.ThirtyDaysOfCode;

namespace SandboxTests
{
    [TestClass]
    public class ReverseArrayTests
    {
        [TestMethod]
        public void Array_IsReversed()
        {
            int[] actual = { 4, 7, 8, 9 };
            int[] reversed = { 9, 8, 7, 4 };
            int[] expected = new int[4];

            expected = (int[])ReverseArray.Reverse(actual);

            CollectionAssert.AreEqual(expected, reversed);
        }
    }
}
