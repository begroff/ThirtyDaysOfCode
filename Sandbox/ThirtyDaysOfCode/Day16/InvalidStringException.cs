using System;
using System.Text;

namespace Sandbox.ThirtyDaysOfCode
{
    public class InvalidStringException : Exception
    {
        public InvalidStringException()
        {

        }

        public InvalidStringException(string message) : base(message)
        {

        }
    }
}