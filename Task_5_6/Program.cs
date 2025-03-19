using System;

namespace Task_5_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int rows = 5, cols = 5;
            int[,] t = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    t[i, j] = (i + j) % 2;
                }
            }
            Console.WriteLine("Двумерный массив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(t[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
