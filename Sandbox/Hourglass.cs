using System;
using System.IO;

namespace Sandbox
{
    public class Hourglass
    {
        public int[][] hourglassArray { get; private set; }

        public int calculateLargestHourglassSum()
        {
            hourglassArray = CreateHourglassArray();

            return 0;
        }

        private int[][] CreateHourglassArray()
        {
            int[][] hourglassArray = new int[6][];

            StreamReader file = new StreamReader(@"C:\Users\brett\projects\CSharp-Playground\Sandbox\hourglass.txt");

            for (int i = 0; i < 6; i++)
            {
                hourglassArray[i] = Array.ConvertAll(file.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }

            return hourglassArray;
        }
    }
}
