//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Tuan1
//{
//    class QuickSort
//    {
//        static void Main(string[] args)
//        {
//            Console.Title = "Quick Sort";
//            var numbers = new[] { 10, 3, 1, 7, 9, 2, 0 };
//            Quicksort(numbers, 0, numbers.Length - 1);
//            Console.WriteLine("Mang sau khi sap xep:");
//            foreach (var number in numbers)
//            {
//                Console.Write(number + " ");
//            }
//            Console.ReadKey();
//        }
//        static void Quicksort(int[] arr, int low, int high)
//        {
//            if (low < high)
//            {
//                int pivotIndex = Partition(arr, low, high);
//                Quicksort(arr, low, pivotIndex - 1);
//                Quicksort(arr, pivotIndex + 1, high);
//            }
//        }
//        static int Partition(int[] arr, int low, int high)
//        {
//            int pivot = arr[high];
//            int i = low - 1;
//            for (int j = low; j < high; j++)
//            {
//                if (arr[j] < pivot)
//                {
//                    i++;
//                    int temp = arr[i];
//                    arr[i] = arr[j];
//                    arr[j] = temp;
//                }
//            }
//            int temp2 = arr[i + 1];
//            arr[i + 1] = arr[high];
//            arr[high] = temp2;
//            return i + 1;
//        }
//    }
//}
