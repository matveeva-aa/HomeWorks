using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_15
{
    internal class Program
    {
        class Computer
        {
            public int Id { get; set; }
            public string Brand { get; set; }
            public string CPU { get; set; }
            public double CPUFreqGHz { get; set; }
            public int RAM { get; set; }
            public int SSD { get; set; }
            public int GPU { get; set; }
            public decimal Price { get; set; }
            public int Quantity { get; set; }

            public override string ToString()
            {
                return $"{Brand}, CPU: {CPU} {CPUFreqGHz}GHz, RAM: {RAM}GB, SSD: {SSD}GB, GPU: {GPU}GB, Цена: {Price} у.е., Кол-во: {Quantity}";
            }
        }

        static void Main(string[] args)
        {
            List<Computer> computers = new List<Computer>
            {
                new Computer { Id = 1, Brand = "Dell", CPU = "Intel i5", CPUFreqGHz = 2.9, RAM = 8, SSD = 256, GPU = 4, Price = 600, Quantity = 12 },
                new Computer { Id = 2, Brand = "HP", CPU = "Intel i7", CPUFreqGHz = 3.1, RAM = 16, SSD = 512, GPU = 6, Price = 900, Quantity = 5 },
                new Computer { Id = 3, Brand = "Lenovo", CPU = "AMD Ryzen 5", CPUFreqGHz = 3.5, RAM = 8, SSD = 512, GPU = 4, Price = 750, Quantity = 30 },
                new Computer { Id = 4, Brand = "Asus", CPU = "Intel i5", CPUFreqGHz = 2.5, RAM = 4, SSD = 256, GPU = 2, Price = 450, Quantity = 7 },
                new Computer { Id = 5, Brand = "Acer", CPU = "AMD Ryzen 7", CPUFreqGHz = 3.8, RAM = 16, SSD = 1024, GPU = 8, Price = 1200, Quantity = 3 },
                new Computer { Id = 6, Brand = "MSI", CPU = "Intel i9", CPUFreqGHz = 3.9, RAM = 32, SSD = 2048, GPU = 12, Price = 2500, Quantity = 2 }
            };

            Console.Write("Введите нужный тип процессора: ");
            string userCPU = Console.ReadLine();
            var filteredByCPU = computers
                .Where(c => c.CPU == userCPU);
            Console.WriteLine("\nКомпьютеры с процессором " + userCPU + ":");
            foreach (var c in filteredByCPU)
                Console.WriteLine(c);

            Console.Write("\nВведите минимальный объём ОЗУ: ");
            int userRAM = int.Parse(Console.ReadLine());
            var filteredByRAM = computers
                .Where(c => c.RAM >= userRAM);
            Console.WriteLine($"\nКомпьютеры с ОЗУ от {userRAM} ГБ:");
            foreach (var c in filteredByRAM)
                Console.WriteLine(c);

            var sortedByPrice = computers
                .OrderBy(c => c.Price);
            Console.WriteLine("\nКомпьютеры по возрастанию цены:");
            foreach (var c in sortedByPrice)
                Console.WriteLine(c);

            var groupedByCPU = computers
                .GroupBy(c => c.CPU);
            Console.WriteLine("\nГруппировка по типу процессора:");
            foreach (var group in groupedByCPU)
            {
                Console.WriteLine($"Тип процессора: {group.Key}");
                foreach (var c in group)
                    Console.WriteLine("  " + c);
            }

            var mostExpensive = computers
                .OrderByDescending(c => c.Price).First();
            var cheapest = computers
                .OrderBy(c => c.Price).First();
            Console.WriteLine($"\nСамый дорогой компьютер: {mostExpensive}");
            Console.WriteLine($"Самый дешёвый компьютер: {cheapest}");

            bool hasLargeStock = computers.Any(c => c.Quantity >= 30);
            Console.WriteLine($"\nЕсть ли хотя бы один компьютер с количеством ≥ 30? {hasLargeStock}");

            Console.ReadKey();
        }
    }
}
