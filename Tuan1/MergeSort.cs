//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Tuan1
//{
//    class MergeSort
//    {
//        static void Main(string[] args)
//        {
//            Console.Title = "Merge Sort";
//            var numbers = new[] { 10, 3, 1, 7, 9, 2, 0 };
//            Mergesort(numbers);
//            Console.WriteLine("Mang sau khi sap xep:");
//            foreach (var number in numbers)
//            {
//                Console.Write(number + " ");
//            }
//            Console.ReadKey();
//        }
//        static void Mergesort(int[] arr)
//        {
//            if (arr.Length <= 1)
//                return;
//            int middle = arr.Length / 2;
//            int[] left = new int[middle];
//            int[] right = new int[arr.Length - middle];
//            Array.Copy(arr, 0, left, 0, middle);
//            Array.Copy(arr, middle, right, 0, arr.Length - middle);
//            Mergesort(left);
//            Mergesort(right);
//            Merge(arr, left, right);
//        }
//        static void Merge(int[] arr, int[] left, int[] right)
//        {
//            int i = 0, j = 0, k = 0;
//            while (i < left.Length && j < right.Length)
//            {
//                if (left[i] <= right[j])
//                {
//                    arr[k] = left[i];
//                    i++;
//                }
//                else
//                {
//                    arr[k] = right[j];
//                    j++;
//                }
//                k++;
//            }
//            while (i < left.Length)
//            {
//                arr[k] = left[i];
//                i++;
//                k++;
//            }
//            while (j < right.Length)
//            {
//                arr[k] = right[j];
//                j++;
//                k++;
//            }
//        }
//    }
//}
