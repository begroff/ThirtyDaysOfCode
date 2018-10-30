using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sandbox.ThirtyDaysOfCode;
using System.IO;
using System;

namespace SandboxTests
{
    [TestClass]
    public class PersonStudentTests
    {
        private string firstName = "";
        private string lastName = "";
        private int id = 0;
        private int[] scores;
        private char letterGrade;

        [TestMethod]
        public void CalculateAverageGrade_OutputIsCorrect()
        {
            firstName = "Brett";
            lastName = "Groff";
            id = 69211269;
            scores = new int[3] { 100, 90, 75 };
            Student newStudent = new Student(firstName, lastName, id, scores);
            string expectedOutput = "";

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                newStudent.printPerson();
                letterGrade = newStudent.Calculate();
                newStudent.printLetterGrade();

                expectedOutput = $"Name: {lastName}, {firstName} ID: {id} Grade: {letterGrade}";

                Assert.AreEqual('E', letterGrade);
                Assert.AreEqual(expectedOutput, sw.ToString());
            }
        }
    }
}