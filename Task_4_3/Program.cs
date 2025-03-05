using System.Numerics;

namespace Task_4_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите число b: ");
            int b = int.Parse(Console.ReadLine());
            int c = 1;
            for (int d = 1; d <= b; d++)
            {
                c *= a;
            }
            Console.WriteLine($"{a}^{b} = {c}");
            Console.ReadKey();
        }
    }
}