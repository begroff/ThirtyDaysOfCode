using System;
using System.Linq;

namespace ThirtyDaysOfCode.Day12
{
    public class Person
    {
        protected string firstName;
        protected string lastName;
        protected int id;

        public Person()
        {

        }

        public Person(string firstName, string lastName, int identification)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = identification;
        }

        public void printPerson()
        {
            Console.Write("Name: " + lastName + ", " + firstName + " ID: " + id + " ");
        }
    }
}