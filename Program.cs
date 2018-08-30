using System;
using System.Collections.Generic;
using c_sharp_playground.Graphs;

namespace c_sharp_playground
{
    class Program
    {
        public static void Main(string[] args)
        {
            int number = 5422;
            int[] arrayOfNumbers = { 4, 7, 8, 9 };

            ReverseArray(arrayOfNumbers);
            ConvertToBinaryAndGetMaxConsecutiveOnes(number);
            ConvertBase10ToBinaryString(number);

            DepthFirstSearch dfs = new DepthFirstSearch();
            dfs.Run();

            BreadthFirstSearch bfs = new BreadthFirstSearch();
            bfs.Run();
        }

        /// <summary>
        /// Reverses an array using my own implementation
        /// </summary>
        public static void ReverseArray<T>(IList<T> array)
        {
            Console.WriteLine("Original Array:");
            CustomArray.Print(array);

            Console.WriteLine("Reversing...");
            array = CustomArray.Reverse(array);

            Console.WriteLine("Reversed Array:");
            CustomArray.Print(array);
        }

        /// <summary>
        /// Converts a base 10 number to its binary representation as a list and
        /// determines the maximum number of consecutive ones in the number.
        /// </summary>
        public static void ConvertToBinaryAndGetMaxConsecutiveOnes(int number)
        {
            string binary = CustomConvert.Base10ToBinaryString(number);
            List<int> consecutiveOnes = new List<int>();
            int onesCount = 0;
            int max = 0;

            for (int i = 0; i < binary.Length; i++)
            {
                if (binary[i] == '1')
                {
                    onesCount++;
                }

                // We've reached a 0 or the end, add our ones count to a list
                if (binary[i] == '0' || i == binary.Length - 1)
                {
                    consecutiveOnes.Add(onesCount);
                    onesCount = 0;
                }
            }

            // Find the maximum number of consecutive ones from our list
            max = consecutiveOnes[0]; // Set the first element as the largest
            for (int j = 0; j < consecutiveOnes.Count; j++)
            {
                if (consecutiveOnes[j] > max)
                {
                    max = consecutiveOnes[j];
                }
            }

            Console.WriteLine(
                $"Number:{number} Binary:{binary} Max Consecutive Ones: {max}");
        }

        /// <summary>
        /// Converts and interger to its binary representation as a string
        /// </summary>
        /// <param name="number">The integer to convert</param>
        public static void ConvertBase10ToBinaryString(int number)
        {
            string binary = CustomConvert.Base10ToBinaryString(number);
            Console.WriteLine($"Number:{number} Binary:{binary}");
        }
    }
}