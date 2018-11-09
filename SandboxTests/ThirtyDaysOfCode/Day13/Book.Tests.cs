using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sandbox.ThirtyDaysOfCode.Day13;
using System.IO;
using System;

namespace SandboxTests.ThirtyDaysOfCode.Day13
{
    [TestClass]
    public class BookTests
    {
        [TestMethod]
        public void AbstractBookTest()
        {
            using (StringWriter writer = new StringWriter())
            {
                string title = "The Alchemist";
                string author = "Paulo Coelho";
                int price = 248;
                MyBook novel = new MyBook(title, author, price);
                string expectedOutput = $"Title: {title} Author: {author} Price: {price}";

                Console.SetOut(writer);
                novel.display();

                Assert.AreEqual(expectedOutput, writer.ToString());
            }
        }
    }
}