using System.Text.RegularExpressions;

namespace Task_6_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер телефона: ");
            string input = Console.ReadLine();

            string pattern = @"^\+7\(\d{3}\)\d{3}-\d{2}-\d{2}$";

            if (Regex.IsMatch(input, pattern))
                Console.WriteLine("Номер корректный");
            else
                Console.WriteLine("Номер некорректный");

            Console.ReadKey();
        }
    }
}