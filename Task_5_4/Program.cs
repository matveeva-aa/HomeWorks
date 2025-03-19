using System;

namespace Task_5_4
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
                t[i] = rnd.Next(0, 11);
                Console.Write(t[i] + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < n / 2; i++)
            {
                int a = t[i];
                t[i] = t[n - 1 - i];
                t[n - 1 - i] = a;
            }
            Console.Write("Наоборот: ");
            foreach (int num in t)
            {
                Console.Write(num + " ");
            }

            Console.ReadKey();
        }
    }
}
