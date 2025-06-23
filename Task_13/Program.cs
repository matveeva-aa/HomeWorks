using System;

namespace Task_13_1
{
    internal class Program
    {
        public delegate int Transformer(int number);

        public static int[] Transform(int[] numbers, Transformer transformer)
        {
            if (transformer == null)
                throw new ArgumentNullException(nameof(transformer), "Делегат не может быть null");

            int[] result = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                result[i] = transformer.Invoke(numbers[i]);
            }

            return result;
        }

        static void Main(string[] args)
        {
            var numbers = new int[] { -7, 2, -1, 0, 5 };

            var doubled = Transform(numbers, n => n * 2);
            Console.WriteLine("Удвоение: " + string.Join(", ", doubled));

            var squared = Transform(numbers, n => n * n);
            Console.WriteLine("Квадрат: " + string.Join(", ", squared));

            var absolute = Transform(numbers, Math.Abs);
            Console.WriteLine("Модуль: " + string.Join(", ", absolute));

            Console.ReadKey();
        }
    }
}
