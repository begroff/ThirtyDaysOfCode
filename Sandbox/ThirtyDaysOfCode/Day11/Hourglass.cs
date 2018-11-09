using System;
using System.IO;

namespace Sandbox.ThirtyDaysOfCode.Day11
{
    public class Hourglass
    {
        public int[][] hourglassArray { get; private set; }

        public int CalculateLargestHourglassSum()
        {
            int highestSum = int.MinValue;
            int sum = 0;

            hourglassArray = CreateHourglassArray();

            // iterate each row
            for (int i = 0; i < 4; i++)
            {
                // iterate each column
                for (int j = 0; j < 4; j++)
                {
                    // Top row
                    sum += hourglassArray[i][j];
                    sum += hourglassArray[i][j + 1];
                    sum += hourglassArray[i][j + 2];

                    // Middle Row
                    sum += hourglassArray[i + 1][j + 1];

                    // Last Row
                    sum += hourglassArray[i + 2][j];
                    sum += hourglassArray[i + 2][j + 1];
                    sum += hourglassArray[i + 2][j + 2];

                    if (sum > highestSum)
                    {
                        highestSum = sum;
                    }

                    sum = 0;
                }
            }

            return highestSum;
        }

        private int[][] CreateHourglassArray()
        {
            int[][] hourglassArray = new int[6][];

            StreamReader file = new StreamReader("../../../../Sandbox/ThirtyDaysOfCode/Day11/hourglass.txt");

            for (int i = 0; i < 6; i++)
            {
                hourglassArray[i] = Array.ConvertAll(file.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }

            return hourglassArray;
        }


    }
}
