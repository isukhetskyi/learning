using System;
using System.Collections.Generic;

namespace MicrosoftDEV2043x
{
    public static class SortingAlgorithms
    {
        /// <summary>
        /// Sorts array of T using bubble sort algorithm
        /// </summary>
        /// <param name="input">
        /// Unsorted array
        /// </param>
        /// <param name="order">
        /// True - default, sort in ascending order, false - sort in descending order
        /// </param>
        /// <returns>
        /// Sorted array of T
        /// </returns>
        public static T[] BubbleSort<T>(T[] input, bool order = true) where T : IComparable
        {
            var unsortedArray = new T[input.Length];
            Array.Copy(input, unsortedArray, input.Length);
            bool swaped = false;

            do
            {
                swaped = false;
                for(int i = 0; i < unsortedArray.Length - 1; i++)
                {
                    T temp = default(T);
                    var comparisonResult = unsortedArray[i].CompareTo(unsortedArray[i + 1]);
                    if(comparisonResult > 0 && order)
                    {
                        temp = unsortedArray[i + 1];
                        unsortedArray[i + 1] = unsortedArray[i];
                        unsortedArray[i] = temp;
                        swaped = true;
                    }
                    if(comparisonResult < 0 && !order)
                    {
                        temp = unsortedArray[i];
                        unsortedArray[i] = unsortedArray[i + 1];
                        unsortedArray[i + 1] = temp;
                        swaped = true;
                    }
                }
            }
            while(swaped);

            return unsortedArray;
        }
    }
}