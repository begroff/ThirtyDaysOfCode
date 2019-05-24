using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ThirtyDaysOfCode.Day17;

namespace ThirtyDaysOfCodeTests.Day17
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Test_Method()
        {
            // Arrange
            int[][] inputs = {
                new int[] { 3, 5 },
                new int[] { 2, 4 },
                new int[] { -1, -2 },
                new int[] { -1, 3 }
            };

            List<int> successResults = new List<int>();
            List<string> exceptionResults = new List<string>();

            try
            {
                for (int i = 0; i < inputs.Length; i++)
                {
                    successResults.Add(Calculator.power(inputs[i][0], inputs[i][1]));
                }
            }
            catch (Exception ex)
            {
                exceptionResults.Add(ex.Message);
            }

            // Assert
            CollectionAssert.Contains(successResults, 243);
            CollectionAssert.Contains(successResults, 16);
            CollectionAssert.Contains(exceptionResults, "n and p should be non-negative");
        }
    }
}
