using System;

namespace Task_5_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            int[] t = new int[n];
            Random rnd = new Random();

            int positive = 0, negative = 0, zero = 0;

            Console.Write("Массив: ");
            for (int i = 0; i < n; i++)
            {
                t[i] = rnd.Next(-20, 21);
                Console.Write(t[i] + " ");

                if (t[i] > 0)
                    positive++;
                else if (t[i] < 0)
                    negative++;
                else
                    zero++;
            }
            Console.WriteLine();
            Console.WriteLine($"Положительных чисел: {positive}");
            Console.WriteLine($"Отрицательных чисел: {negative}");
            Console.WriteLine($"Чисел, равных нулю: {zero}");
            Console.ReadKey();
        }
    }
}
