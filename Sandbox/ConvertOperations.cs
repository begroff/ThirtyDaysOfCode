using System;
using System.Collections;
using System.Collections.Generic;

namespace Sandbox
{
    public static class ConvertOperations
    {

        /// <summary>
        /// Converts an integer to its binary representation.
        /// </summary>
        /// <param name="number">The integer to convert.</param>
        /// <returns>The binary representation of an integer as a string.</returns>
        public static string Base10ToBinaryString(int number)
        {
            string result = string.Empty;

            while (number > 0)
            {
                int remainder = number % 2;
                result = remainder.ToString() + result;
                number = number / 2;
            }

            return result;
        }
    }
}