using System;

namespace Task_5_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            int[] t = new int[n];
            Random rnd = new Random();

            int a = 0, b = 0;

            Console.Write("Массив: ");
            for (int i = 0; i < n; i++)
            {
                t[i] = rnd.Next(0, 101);
                Console.Write(t[i] + " ");

                if (t[i] % 2 == 0)
                    a++;
                else
                    b++;
            }
            Console.WriteLine();
            if (a > b)
                Console.WriteLine("Чётных чисел больше");
            else if (b > a)
                Console.WriteLine("Нечётных чисел больше");
            else
                Console.WriteLine("Количество чётных и нечётных чисел одинаковое");

            Console.ReadKey();
        }
    }
}