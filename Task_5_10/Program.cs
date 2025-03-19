using System;

namespace Task_5_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 5;
            int[,] field = new int[n, n];
            Random rnd = new Random();

            Console.WriteLine("Поле:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    field[i, j] = rnd.Next(0, 2);
                    Console.Write(field[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            if (CheckWin(field, n))
                Console.WriteLine("Крестики победили");
            else
                Console.WriteLine("Крестики не победили");

            Console.ReadKey();
        }
        static bool CheckWin(int[,] field, int n)
        {
            for (int i = 0; i < n; i++)
            {
                if (CheckRow(field, i, n) || CheckColumn(field, i, n))
                    return true;
            }
            return CheckMainDiagonal(field, n) || CheckSecondaryDiagonal(field, n);
        }
        static bool CheckRow(int[,] field, int row, int n)
        {
            for (int j = 0; j < n; j++)
                if (field[row, j] != 1) return false;
            return true;
        }
        static bool CheckColumn(int[,] field, int col, int n)
        {
            for (int i = 0; i < n; i++)
                if (field[i, col] != 1) return false;
            return true;
        }
        static bool CheckMainDiagonal(int[,] field, int n)
        {
            for (int i = 0; i < n; i++)
                if (field[i, i] != 1) return false;
            return true;
        }
        static bool CheckSecondaryDiagonal(int[,] field, int n)
        {
            for (int i = 0; i < n; i++)
                if (field[i, n - 1 - i] != 1) return false;
            return true;
        }
    }
}
