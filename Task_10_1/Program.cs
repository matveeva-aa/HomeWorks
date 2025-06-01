using System;

namespace Task_10_1
{
    class Program
    {
        static void Main()
        {
            Building building = new Building("ул. Ленина, 1", 500.0, 1990);
            building.DisplayInfo();
            Console.WriteLine($"Налог: {building.CalculateTax()} р.");
            Console.WriteLine();

            MultiBuilding multiBuilding = new MultiBuilding("Лермонтовский пр, 29", 2000.0, 2005, 10, true);
            multiBuilding.DisplayInfo();
            Console.WriteLine($"Налог: {multiBuilding.CalculateTax()} р.");
            Console.WriteLine();

            Building buildingUpcast = multiBuilding;
            Console.WriteLine("Приведение производного класса к базовому");
            buildingUpcast.DisplayInfo();
            Console.WriteLine($"Налог: {buildingUpcast.CalculateTax()} р.");
            Console.WriteLine();

            if (buildingUpcast is MultiBuilding downcasted)
            {
                Console.WriteLine("Обратное приведение с проверкой типа:");
                Console.WriteLine($"Средняя площадь на этаж: {downcasted.AreaPerFloor} кв.м.");
            }

            Console.ReadKey();
        }
    }
}
