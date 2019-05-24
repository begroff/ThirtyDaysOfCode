using System;

namespace ThirtyDaysOfCode.Day12
{
    public class Student : Person
    {
        private int[] testScores;
        private char letterGrade { get; set; }

        public Student(string firstName, string lastName, int id, int[] testScores)
        : base(firstName, lastName, id)
        {
            this.testScores = testScores;
        }

        public char Calculate()
        {
            int total = 0;
            int average = 0;

            foreach (int testScore in testScores)
            {
                total += testScore;
            }

            average = total / testScores.Length;
            letterGrade = GetLetterGrade(average);

            return letterGrade;
        }

        public char GetLetterGrade(int average)
        {
            char letterGrade;
            if (average >= 90)
            {
                letterGrade = 'O';
            }
            else if (average >= 80)
            {
                letterGrade = 'E';
            }
            else if (average >= 70)
            {
                letterGrade = 'A';
            }
            else if (average >= 55)
            {
                letterGrade = 'P';
            }
            else if (average >= 40)
            {
                letterGrade = 'D';
            }
            else
            {
                letterGrade = 'T';
            }

            return letterGrade;
        }

        public void printLetterGrade()
        {
            Console.Write($"Grade: {letterGrade}");
        }
    }
}