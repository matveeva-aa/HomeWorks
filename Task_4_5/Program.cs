using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Numerics;

namespace Task_4_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            do
            {
                Console.Write("Введите число из диапазона [20; 60]: ");
            a = int.Parse(Console.ReadLine());
            
            if (a < 20 || a > 60)
            {
                Console.WriteLine("Ошибка! Число должно быть в диапазоне от 20 до 60.");
                }

        } while (a< 20 || a> 60);

            Console.WriteLine($"Число верное");
            Console.ReadKey();
        }
    }
}
