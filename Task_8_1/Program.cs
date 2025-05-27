using System;

namespace Task_8_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите первое число: ");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите второе число: ");
                int b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Выберите операцию:");
                Console.WriteLine("1 – сложение");
                Console.WriteLine("2 – вычитание");
                Console.WriteLine("3 – умножение");
                Console.WriteLine("4 – деление");
                Console.Write("Код операции: ");
                int op = Convert.ToInt32(Console.ReadLine());

                double result = 0;

                switch (op)
                {
                    case 1:
                        result = a + b;
                        Console.WriteLine($"Результат: {result}");
                        break;
                    case 2:
                        result = a - b;
                        Console.WriteLine($"Результат: {result}");
                        break;
                    case 3:
                        result = a * b;
                        Console.WriteLine($"Результат: {result}");
                        break;
                    case 4:
                        result = (double)a / b;
                        Console.WriteLine($"Результат: {result}");
                        break;
                    default:
                        Console.WriteLine("Неизвестный код операции");
                        break;
                }
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Ошибка: деление на ноль недопустимо");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: введено не число");
            }

            Console.ReadKey();

        }
    }
}
