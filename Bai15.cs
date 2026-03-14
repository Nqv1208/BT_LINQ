using System;
using System.Collections.Generic;
using System.Linq;

namespace BT_LINQ
{
    public class Bai15
    {
        public static void Main(string[] args)
        {
            Console.Write("--------------------------\n");
            Console.Write("Thông tin sinh viên:\n");
            Console.Write("Họ và tên: Nguyễn Quang Vinh\n");
            Console.Write("Mã sinh viên: 23115053122346\n");
            Console.Write("Lớp học phần: Lập trình C#\n");
            Console.Write("--------------------------\n");

            List<int> numbers = new List<int>(){1, 2, 2, 3, 4, 4, 5};
            Console.WriteLine("Danh sách ban đầu:");
            foreach (var num in numbers)  
          {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            var distinctNumbers = numbers.Distinct();
            Console.WriteLine("Danh sách sau khi loại bỏ trùng:");
            foreach (var num in distinctNumbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}