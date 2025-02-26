using System;

namespace Task_2_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите четырехзначное число: ");
            int number = int.Parse(Console.ReadLine());

            int first = number / 1000;
            int second = (number / 100) % 10;
            int third = (number / 10) % 10;
            int fourth = number % 10;
            int newNumber = first * 1000 + fourth * 100 + third * 10 + second;

            Console.WriteLine(newNumber);
            Console.ReadKey();
        }
    }
}
