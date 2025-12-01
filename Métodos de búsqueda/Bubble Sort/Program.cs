using System;

namespace Bubble_Sort
{
    class Program
    {
        static void Main()
        {
            int[] arr = { 5, 2, 9, 1, 5, 6 };
            BubbleSortAlgorithm.BubbleSort(arr);
            Console.WriteLine(string.Join(", ", arr));
            Console.ReadLine(); // mantener la consola abierta al depurar
        }
    }

    class BubbleSortAlgorithm
    {
        public static void BubbleSort(int[] array)
        {   
            int n = array.Length;
            bool swapped;

            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;

                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        swapped = true;
                    }
                }

                if (!swapped) break;
                Console.WriteLine($"Pass {i + 1}: {string.Join(", ", array)}");
            }
        }
    }
}
