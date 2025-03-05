using System.Numerics;

namespace Task_4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число n: ");
            int n = int.Parse(Console.ReadLine());
            double b = 0;
            for (int a = 1; a <= n; a++)
            {
                 b += 1.0/a; 
            }
            Console.WriteLine($"Сумма 1 + 1/2 + 1/3 + 1/n = {b}"); 
            Console.ReadKey();
        }
    }
}