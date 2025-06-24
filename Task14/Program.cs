using System;
using System.Collections.Generic;

namespace Task_14_1
{
    internal class Program
    {
        static void Main()
        {
            List<string> team = new List<string>();

            team.Add("Иванов");
            team.Add("Петров");
            team.Add("Сидоров");
            team.Insert(1, "Козлов");

            bool hasPetrov = team.Contains("Петров");
            Console.WriteLine($"Есть ли игрок 'Петров' в команде? {hasPetrov}");

            team.Remove("Сидоров");

            int kozlovIndex = team.IndexOf("Козлов");
            Console.WriteLine($"Индекс игрока 'Козлов': {kozlovIndex}");

            team.Sort();

            Console.WriteLine("\nТекущий состав команды:");
            for (int i = 0; i < team.Count; i++)
            {
                Console.WriteLine($"  {i + 1}. {team[i]}");
            }

            Console.WriteLine($"\nКоманда пуста? {team.Count == 0}");

            team.Clear();
            Console.WriteLine($"Количество игроков после очистки: {team.Count}");

            Console.ReadKey();
        }
    }
}
