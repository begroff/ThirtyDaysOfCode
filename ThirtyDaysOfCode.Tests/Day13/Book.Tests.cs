using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;
using ThirtyDaysOfCode.Day13;

namespace ThirtyDaysOfCodeTests.Day13
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