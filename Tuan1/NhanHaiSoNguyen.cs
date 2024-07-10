//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Tuan1
//{
//    class NhanHaiSoNguyen
//    {
//        static void Main(string[] args)
//        {
//            Console.Title = "Tích hai số nguyên lớn nhất trong mảng";
//            var numbers = new[] { 10, 3, 5, 8, 2, 7 };
//            long product = FindMaxProduct(numbers);
//            Console.WriteLine("Tich hai so nguyen lon nhat trong mang: " + product);
//            Console.ReadKey();
//        }
//        static long FindMaxProduct(int[] arr)
//        {
//            if (arr.Length < 2)
//            {
//                throw new ArgumentException("Mang phai chua it nhat 2 so nguyen.");
//            }
//            long maxProduct = long.MinValue;
//            int maxIndex1 = -1;
//            int maxIndex2 = -1;
//            for (int i = 0; i < arr.Length; i++)
//            {
//                for (int j = i + 1; j < arr.Length; j++)
//                {
//                    long product = (long)arr[i] * arr[j];
//                    if (product > maxProduct)
//                    {
//                        maxProduct = product;
//                        maxIndex1 = i;
//                        maxIndex2 = j;
//                    }
//                }
//            }
//            Console.WriteLine("So nguyen lon nhat: " + arr[maxIndex1]);
//            Console.WriteLine("So nguyen thu hai lon nhat: " + arr[maxIndex2]);
//            return maxProduct;
//        }
//    }
//}
