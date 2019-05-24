using System;

namespace ThirtyDaysOfCode.Day16
{
    public static class ConvertString
    {
        public static int ToInteger(string value)
        {
            int number = 0;

            try
            {
                number = Int32.Parse(value);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new InvalidStringException("Bad String");
            }

            return number;
        }
    }
}