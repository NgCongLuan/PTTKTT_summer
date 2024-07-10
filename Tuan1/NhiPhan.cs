//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Tuan1
//{
//    class NhiPhan
//    {
//        static void Main(string[] args)
//        {
//            Console.Title = "Tìm kiếm nhị phân";
//            var numbers = new[] { 10, 3, 1, 7, 9, 2, 0 };
//            int target = 2;
//            Array.Sort(numbers);
//            int index = BinarySearch(numbers, target);
//            if (index != -1)
//            {
//                Console.WriteLine("Gia tri {0} duoc tim thay tai vi tri {1} trong mang.", target, index);
//            }
//            else
//            {
//                Console.WriteLine("Gia tri {0} khong ton tai trong mang.", target);
//            }
//            Console.ReadKey();
//        }
//        static int BinarySearch(int[] arr, int target)
//        {
//            int low = 0;
//            int high = arr.Length - 1;
//            while (low <= high)
//            {
//                int mid = (low + high) / 2;

//                if (arr[mid] == target)
//                {
//                    return mid;S
//                }
//                else if (arr[mid] < target)
//                {
//                    low = mid + 1;
//                }
//                else
//                {
//                    high = mid - 1;
//                }
//            }
//            return -1;
//        }
//    }
//}
