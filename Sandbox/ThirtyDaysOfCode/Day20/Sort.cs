using System;

namespace Sandbox.ThirtyDaysOfCode.Day20
{
    public class Sort
    {
        public int NumberOfSwaps { get; set; } = 0;
        public int[] BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    // If element is greater, swap it
                    if (arr[j] > arr[j + 1])
                    {
                        int numberToSwap = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = numberToSwap;
                        NumberOfSwaps++;
                    }
                }

                // If no elements were swapped during a traversal, array is sorted
                if (NumberOfSwaps == 0)
                {
                    break;
                }
            }

            return arr;
        }
    }
}