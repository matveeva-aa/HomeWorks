using System.Reflection;

namespace Task_4_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите положительное число a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите отрицательное число b: ");
            int b = int.Parse(Console.ReadLine());
           int moduleB = -b;
            double stepenA = 1;
            for (int d = 1; d <= moduleB; d++)
            {
               stepenA  *= a;
            }
            stepenA = 1.0 / stepenA;
            Console.WriteLine($"{a}^({b}) = {stepenA}");
            Console.ReadKey();
        }
    }
}
