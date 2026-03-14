namespace BT_LINQ
{
    public class Bai1
    {
        public static void Main(string[] args)
        {
            List<int> numbers = new List<int>{1, 2, 3, 4, 5, 6, 7, 8};
            var evenNumbers = numbers.Where(num => num % 2 == 0);
            Console.WriteLine("Các số chẵn:");
            foreach (var num in evenNumbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}