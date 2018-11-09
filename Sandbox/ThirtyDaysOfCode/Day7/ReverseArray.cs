using System;
using System.Collections;
using System.Collections.Generic;

namespace Sandbox.ThirtyDaysOfCode.Day7
{
    public static class ReverseArray
    {
        /// <summary>
        /// Reverses an array or list.
        /// </summary>
        /// <param name="arr">The array or list to reverse.</param>
        /// <typeparam name="T">The type elements in the array or list (e.g. int, string, etc.).</typeparam>
        /// <returns>The array or list in reverse order.</returns>
        public static IList<T> Reverse<T>(IList<T> arr)
        {

            for (int i = 0; i < arr.Count / 2; i++)
            {
                T temp = arr[i];
                arr[i] = arr[arr.Count - i - 1];
                arr[arr.Count - i - 1] = temp;
            }

            return arr;
        }
    }
}