using System;

namespace Task_5_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int rows = 10, cols = 5;
            int[,] t = new int[rows, cols];
            Random rnd = new Random();

            Console.WriteLine("Двумерный массив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    t[i, j] = rnd.Next(0, 11);
                    Console.Write(t[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Max:");
            for (int i = 0; i < rows; i++)
            {
                int max = t[i, 0];
                for (int j = 1; j < cols; j++)
                {
                    if (t[i, j] > max)
                        max = t[i, j];
                }
                Console.WriteLine($"Строка {i + 1}: {max}");
            }
            Console.ReadKey();
        }
    }
}
