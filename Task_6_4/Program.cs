﻿using System.Text;

namespace Task_6_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();

            Console.Write("Введите возраст: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Введите город: ");
            string city = Console.ReadLine();

            StringBuilder sb = new StringBuilder();
            sb.Append("Имя: ").Append(name)
              .Append(", Возраст: ").Append(age)
              .Append(", Город: ").Append(city);

            Console.WriteLine();
            Console.WriteLine("Результат: " + sb.ToString());

            Console.ReadKey();
        }
    }
}