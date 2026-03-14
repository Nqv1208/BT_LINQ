using System;
using System.Collections.Generic;
using System.Linq;

namespace BT_LINQ
{
    public class Bai3
    {
        public static void Main(string[] args)
        {
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
            var sorted = numbers.OrderBy(num => num);
            Console.WriteLine("Danh sách sắp xếp tăng dần:");
            foreach (var num in sorted)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}