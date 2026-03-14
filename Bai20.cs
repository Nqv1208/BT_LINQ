using System;
using System.Collections.Generic;
using System.Linq;

namespace BT_LINQ
{
    public class Bai20
    {
        public static void Main(string[] args)
        {
            Console.Write("--------------------------\n");
            Console.Write("Thông tin sinh viên:\n");
            Console.Write("Họ và tên: Nguyễn Quang Vinh\n");
            Console.Write("Mã sinh viên: 23115053122346\n");
            Console.Write("Lớp học phần: Lập trình C#\n");
            Console.Write("--------------------------\n");

            Console.Write("Nhập số lượng sinh viên: ");
            string? input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input) || !int.TryParse(input, out int n))
            {
                Console.WriteLine("Lỗi: Vui lòng nhập một số nguyên hợp lệ.");
                return;
            }
            List<Student> students = new List<Student>();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Nhập thông tin sinh viên {i + 1}:");
                Console.Write("Id: ");
                input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input) || !int.TryParse(input, out int id))
                {
                    Console.WriteLine("Lỗi: Vui lòng nhập một số nguyên hợp lệ cho Id.");
                    return;
                }
                Console.Write("Name: ");
                string? name = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine("Lỗi: Tên không được để trống.");
                    return;
                }
                Console.Write("Score: ");
                input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input) || !double.TryParse(input, out double score))
                {
                    Console.WriteLine("Lỗi: Vui lòng nhập một số thực hợp lệ cho Score.");
                    return;
                }
                students.Add(new Student { Id = id, Name = name, Score = score });
            }
            var top3 = students.OrderByDescending(s => s.Score).Take(3);
            Console.WriteLine("Top 3 sinh viên điểm cao nhất:");
            foreach (var student in top3)
            {
                Console.WriteLine($"{student.Name}: {student.Score}");
            }
        }
    }
}