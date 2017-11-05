using System;

namespace MicrosoftDEV2043x
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] array = new int[]{3, 5, 2, 1, 1, 2, 8 };

            var ascArray = SortingAlgorithms.BubbleSort(array);
            var descArray = SortingAlgorithms.BubbleSort(array, false);

            Console.WriteLine(string.Join(",", ascArray));
            Console.WriteLine(string.Join(",", descArray));
        }
    }
}
