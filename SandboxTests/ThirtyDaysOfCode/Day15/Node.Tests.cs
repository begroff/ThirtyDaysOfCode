using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sandbox.ThirtyDaysOfCode;

namespace SandboxTests.ThirtyDaysOfCode
{
    [TestClass]
    public class NodeTests
    {
        [TestMethod]
        public void Node_Insert_Test()
        {
            // Arrange
            int[] values = { 2, 3, 4, 1 };
            Node linkedList = null;

            // Act
            for (int i = 0; i < values.Length; i++)
            {
                linkedList = Node.Insert(linkedList, values[i]);
            }

            // Assert
            Assert.IsTrue(linkedList.ToString(linkedList).Contains("2 3 4 1"));
        }
    }
}