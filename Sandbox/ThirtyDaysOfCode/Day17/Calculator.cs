using System;

namespace Sandbox.ThirtyDaysOfCode
{
    public static class Calculator
    {
        public static int power(int n, int p)
        {
            int result = 0;

            if (n < 0 || p < 0 )
            {
                throw new Exception("n and p should be non-negative");
            }

            result = Convert.ToInt32(
                Math.Pow(Convert.ToDouble(n), Convert.ToDouble(p))
            );

            return result;
        }
    }
}
