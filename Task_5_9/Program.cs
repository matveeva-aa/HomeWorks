using System;

namespace Task_5_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int m = 5, n = 5;
            int[,] A = new int[m, n];

            FillSpiral(A, m, n);
            PrintMatrix(A, m, n);

            Console.ReadKey();
        }
        static void FillSpiral(int[,] A, int m, int n)
        {
            int value = 1;
            int top = 0, bottom = m - 1, left = 0, right = n - 1;

            while (value <= m * n)
            {
                for (int i = left; i <= right; i++)
                    A[top, i] = value++;
                top++;
                for (int i = top; i <= bottom; i++)
                    A[i, right] = value++;
                right--;
                for (int i = right; i >= left; i--)
                    A[bottom, i] = value++;
                bottom--;
                for (int i = bottom; i >= top; i--)
                    A[i, left] = value++;
                left++;
            }
        }
        static void PrintMatrix(int[,] A, int m, int n)
        {
            Console.WriteLine("Матрица:");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(A[i, j].ToString().PadLeft(3));
                }
                Console.WriteLine();
            }
        }
    }
}
