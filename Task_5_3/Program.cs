using System;

namespace Task_5_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            int[] t = new int[n];
            Random rnd = new Random();

            Console.Write("Массив: ");
            for (int i = 0; i < n; i++)
            {
                t[i] = rnd.Next(0, 51);
                Console.Write(t[i] + " ");
            }
            Console.WriteLine();

            int max = t[0], min = t[0];
            int maxIndex = 0, minIndex = 0;

            for (int i = 1; i < n; i++)
            {
                if (t[i] > max)
                {
                    max = t[i];
                    maxIndex = i;
                }
                if (t[i] < min)
                {
                    min = t[i];
                    minIndex = i;
                }
            }
            Console.WriteLine($"Максимальный элемент: {max}, индекс: {maxIndex}");
            Console.WriteLine($"Минимальный элемент: {min}, индекс: {minIndex}");

            Console.ReadKey();
        }
    }
}
