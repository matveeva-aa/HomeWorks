using System;

namespace Task_5_5
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
                t[i] = rnd.Next(-50, 51);
                Console.Write(t[i] + " ");
            }
            Console.WriteLine();

            Array.Sort(t, 0, 5);
            Array.Sort(t, 5, 5);
            Array.Reverse(t, 5, 5);

            Console.Write("Отсортированный массив: ");
            foreach (int num in t)
            {
                Console.Write(num + " ");
            }

            Console.ReadKey();
        }
    }
}
