using System;
using System.Collections.Generic;
using System.Linq;

namespace BT_LINQ
{
    public class Bai5
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
            var squares = numbers.Select(num => num * num);
            Console.WriteLine("Bình phương các số:");
            foreach (var num in squares)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}