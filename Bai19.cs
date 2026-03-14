using System;
using System.Collections.Generic;
using System.Linq;

namespace BT_LINQ
{
    public class Bai19
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
            if (string.IsNullOrWhiteSpace(input) || !int.TryParse(input, out int n))
            {
                Console.WriteLine("Lỗi: Vui lòng nhập một số nguyên hợp lệ.");
                return;
            }
            List<int> numbers = new List<int>();
            Console.WriteLine("Nhập các số:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Số {i + 1}: ");
                input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input) || !int.TryParse(input, out int num))
                {
                    Console.WriteLine("Lỗi: Vui lòng nhập một số nguyên hợp lệ.");
                    return;
                }
                numbers.Add(num);
            }
            var mostFrequent = numbers.GroupBy(num => num)
                                      .OrderByDescending(g => g.Count())
                                      .First()
                                      .Key;
            Console.WriteLine("Số xuất hiện nhiều nhất: " + mostFrequent);
        }
    }
}