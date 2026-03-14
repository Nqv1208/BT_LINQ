using System;
using System.Collections.Generic;
using System.Linq;

namespace BT_LINQ
{
    public class Bai11
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
            if (!int.TryParse(input, out int n) || n <= 0)
            {
                Console.WriteLine("Invalid input");
                return;
            }
            List<Student> students = new List<Student>();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Nhập thông tin sinh viên {i + 1}:");
                Console.Write("Id: ");
                string? idInput = Console.ReadLine();
                if (!int.TryParse(idInput, out int id))
                {
                    Console.WriteLine("Invalid id");
                    return;
                }
                Console.Write("Name: ");
                string name = Console.ReadLine() ?? "";
                Console.Write("Score: ");
                string? scoreInput = Console.ReadLine();
                if (!double.TryParse(scoreInput, out double score))
                {
                    Console.WriteLine("Invalid score");
                    return;
                }
                students.Add(new Student { Id = id, Name = name, Score = score });
            }
            var topStudent = students.OrderByDescending(s => s.Score).First();
            Console.WriteLine("Sinh viên điểm cao nhất:");
            Console.WriteLine($"{topStudent.Name}: {topStudent.Score}");
        }
    }
}