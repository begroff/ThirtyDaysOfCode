using System;
using System.Collections;
using System.Collections.Generic;

namespace c_sharp_playground
{
    public static class CustomArray
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

        /// <summary>
        /// Prints the elements in an array or list.
        /// </summary>
        /// <param name="arr">The array or list.</param>
        /// <typeparam name="T">The type of elements in the array or list (e.g. int, string, etc).</typeparam>
        public static void Print<T>(IList<T> arr)
        {
            for (int i = 0; i < arr.Count; i++)
            {
                Console.Write(arr[i] + " ");

                if (i == arr.Count - 1)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}