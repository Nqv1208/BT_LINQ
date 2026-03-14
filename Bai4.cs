using System;
using System.Collections.Generic;
using System.Linq;

namespace BT_LINQ
{
    public class Bai4
    {
        public static void Main(string[] args)
        {
            Console.Write("--------------------------\n");
            Console.Write("Thông tin sinh viên:\n");
            Console.Write("Họ và tên: Nguyễn Quang Vinh\n");
            Console.Write("Mã sinh viên: 23115053122346\n");
            Console.Write("Lớp học phần: Lập trình C#\n");
            Console.Write("--------------------------\n");

            Console.Write("Nhập số lượng phần tử: ");
            string? input = Console.ReadLine();
            if (!int.TryParse(input, out int n) || n <= 0)
            {
                Console.WriteLine("Invalid input");
                return;
            }
            List<int> numbers = new List<int>();
            Console.WriteLine("Nhập các số:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Số {i + 1}: ");
                string? numInput = Console.ReadLine();
                if (!int.TryParse(numInput, out int num))
                {
                    Console.WriteLine("Invalid number");
                    return;
                }
                numbers.Add(num);
            }
            var sorted = numbers.OrderByDescending(num => num);
            Console.WriteLine("Danh sách sắp xếp giảm dần:");
            foreach (var num in sorted)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}