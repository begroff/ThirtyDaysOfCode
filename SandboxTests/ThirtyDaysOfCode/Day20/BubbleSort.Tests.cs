using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sandbox.ThirtyDaysOfCode.Day20;

namespace SandboxTests.ThirtyDaysOfCode.Day20
{
    [TestClass]
    public class BubbleSortTests
    {

        [TestMethod]
        public void BubbleSort_ArrayIsSorted()
        {
            // Arrange
            Sort sort = new Sort();
            int[] numbers = { 3, 1, 8, 7, 5, 4, 2 };
            int[] expected = { 1, 2, 3, 4, 5, 7, 8 };

            // Act
            int[] actual = sort.BubbleSort(numbers);

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}