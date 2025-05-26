using System;

namespace Task_7_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 4, b = 5, c = 6;
            int d = 6, e = 7, f = 8;

            if (!IsValid(a, b, c) || !IsValid(d, e, f))
            {
                Console.WriteLine("Один из треугольников не существует");
            }
            else
            {
                double area1 = CalcSquare(a, b, c);
                double area2 = CalcSquare(d, e, f);

                if (area1 > area2)
                {
                    Console.WriteLine("Первый треугольник имеет большую площадь");
                }
                else if (area2 > area1)
                {
                    Console.WriteLine("Второй треугольник имеет большую площадь");
                }
                else
                {
                    Console.WriteLine("Площади треугольников равны");
                }
            }

            Console.ReadKey();
        }

        static double CalcSquare(int x, int y, int z)
        {
            double s = (x + y + z) / 2.0;
            return Math.Sqrt(s * (s - x) * (s - y) * (s - z));
        }

        static bool IsValid(int a, int b, int c)
        {
            return a + b > c && a + c > b && b + c > a;
        }
    }
}
