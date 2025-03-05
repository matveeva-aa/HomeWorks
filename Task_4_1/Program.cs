using System.Numerics;

namespace Task_4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число n: ");
            int n = int.Parse(Console.ReadLine());

            BigInteger factorial = 1; // есть вариант использовать int или long, сильно влияет на скорость если учитываем большие числа?
            for (int a = 1; a <= n; a++)
            {
                factorial *= a;
            }
            Console.WriteLine($"{n}! = {factorial}");
            Console.ReadKey();
        }
    }
}
