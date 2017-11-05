using System;

namespace MicrosoftDEV2043x
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] array = new int[]{3, 5, 2, 1, 1, 2, 8 };

            var ascArray = SortingAlgorithms.InsertationSort(array);
            var descArray = SortingAlgorithms.InsertationSort(array, false);

            Console.WriteLine(string.Join(",", ascArray));
            Console.WriteLine(string.Join(",", descArray));
        }
    }
}
