using System.ComponentModel.Design;

namespace Task_4_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число n: ");
            int n = int.Parse(Console.ReadLine());

            if (n <= 0)
            {
                Console.WriteLine($"{n} не является степенью двойки.");
                Console.ReadKey();
            }
            else
            {
                int a = n;
                do
                {
                    if (a % 2 != 0 && a != 1)
                    {
                        Console.WriteLine($"{n} не является степенью двойки.");
                        Console.ReadKey();
                    }
                    a /= 2;
                } while (a > 1);

                Console.WriteLine($"{n} является степенью двойки.");
                Console.ReadKey();
            }
        }
    }
}