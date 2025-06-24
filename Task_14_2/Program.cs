using System;
using System.Collections.Generic;

namespace Task_14_2
{
    internal class Program
    {
        static void Main()
        {
            Dictionary<string, int> inventory = new Dictionary<string, int>();

            inventory.Add("A001", 10); // Ноутбуки
            inventory.Add("B205", 25); // Смартфоны
            inventory.Add("C307", 15); // Наушники

            bool hasSmartphones = inventory.ContainsKey("B205");
            Console.WriteLine($"Есть ли товар с артикулом B205? {hasSmartphones}");

            inventory["A001"] = 8;

            if (inventory.TryGetValue("C307", out int headphoneCount))
            {
                Console.WriteLine($"Количество наушников: {headphoneCount}");
            }

            inventory["B205"] += 5;

            inventory.Remove("C307");

            Console.WriteLine("\nТекущие товары:");
            foreach (var item in inventory)
            {
                Console.WriteLine($"Артикул: {item.Key}, Количество: {item.Value}");
            }

            Console.WriteLine($"\nСписок пуст? {inventory.Count == 0}");
            inventory.Clear();
            Console.WriteLine($"Количество товаров после очистки: {inventory.Count}");

            Console.ReadKey();
        }
    }
}
