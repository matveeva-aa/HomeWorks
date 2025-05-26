using System;

namespace Task_7_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxNumber = FindMax(10, 25, 5, 30, 15);
            Console.WriteLine($"Max number: {maxNumber}");
            Console.ReadKey();
        }
        static int FindMax(params int[] numbers)
        {
            int max = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            return max;
        }
    }
}

