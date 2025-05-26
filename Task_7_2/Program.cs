using System;

namespace Task_7_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int edgeLength = 7;
            int volume, surfaceArea;

            CalcCube(edgeLength, out volume, out surfaceArea);

            Console.WriteLine($"Объем куба: {volume}");
            Console.WriteLine($"Площадь поверхности куба: {surfaceArea}");

            Console.ReadKey();
        }

        static void CalcCube(int edge, out int volume, out int surface)
        {
            volume = edge * edge * edge;
            surface = 6 * edge * edge;
        }
    }
}
