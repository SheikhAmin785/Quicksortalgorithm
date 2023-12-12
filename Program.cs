using System;

namespace Quicksortalgorithm
{
    class QuickSort
    {
        public static void Quicksort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(arr, left, right);

                Quicksort(arr, left, pivot - 1);
                Quicksort(arr, pivot + 1, right);
            }
        }

        private static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[right];
            int i = left - 1;

            for (int j = left; j < right; j++)
            {
                if (arr[j] <= pivot)
                {
                    i++;
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
            //swap
            int temp1 = arr[i + 1];
            arr[i + 1] = arr[right];
            arr[right] = temp1;

            return i + 1;
        }

        static void Main()
        {
            int[] item= { 8, 875, 7, 9, 764, 55 };

            Console.WriteLine("number of array:");
            foreach (int i in item)
            {
                Console.WriteLine(i);
            }
            Quicksort(item, 0, 5);

            Console.WriteLine("Sorted array:");

            foreach (int i in item)
            {
                Console.WriteLine(i);
            }
        }
    }
}
