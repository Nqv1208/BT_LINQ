using System;
using System.Collections.Generic;
using System.Linq;

namespace BT_LINQ
{
    public class Bai2
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
            var greaterThan5 = numbers.Where(num => num > 5);
            Console.WriteLine("Các số lớn hơn 5:");
            foreach (var num in greaterThan5)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}