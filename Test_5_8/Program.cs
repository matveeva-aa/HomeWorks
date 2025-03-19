using System;

namespace Task_5_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 5;
            int[] t = new int[n];
            Random rnd = new Random();

            Console.Write("Массив: ");
            for (int i = 0; i < n; i++)
            {
                t[i] = rnd.Next(0, 11);
                Console.Write(t[i] + " ");
            }
            Console.WriteLine();

            int max1 = int.MinValue, max2 = int.MinValue;
            foreach (int num in t)
            {
                if (num > max1)
                {
                    max2 = max1;
                    max1 = num;
                }
                else if (num > max2)
                {
                    max2 = num;
                }
            }

            Console.WriteLine($"Два наибольших числа: {max1} и {max2}");

            Console.ReadKey();
        }
    }
}
