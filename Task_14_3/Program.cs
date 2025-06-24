using System;
using System.Collections.Generic;

namespace Task_14_3
{
    internal class Program
    {
        static void Main()
        {
            HashSet<string> subscribers = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            subscribers.Add("alice@example.com");
            subscribers.Add("bob@example.com");
            subscribers.Add("charlie@example.com");

            bool addedDuplicate = subscribers.Add("Alice@Example.com");
            Console.WriteLine($"Дубликат alice@example.com добавлен? {addedDuplicate}");

            Console.WriteLine($"Есть ли bob@example.com в подписчиках? {subscribers.Contains("bob@example.com")}");
            Console.WriteLine($"Есть ли dave@example.com в подписчиках? {subscribers.Contains("dave@example.com")}");

            HashSet<string> newSubscribers = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
            {
                "bob@example.com",
                "dave@example.com",
                "eve@example.com"
            };

            subscribers.UnionWith(newSubscribers);
            Console.WriteLine("\nПодписчики после объединения:");
            foreach (var email in subscribers)
            {
                Console.WriteLine($"- {email}");
            }

            //Тут получается, что общие все из newSubscribers общие, т.к мы объединили, потом пересекли, по идее нужно изменить порядок или может еще есть варианты?
            HashSet<string> commonSubscribers = new HashSet<string>(subscribers, StringComparer.OrdinalIgnoreCase);
            commonSubscribers.IntersectWith(newSubscribers);
            Console.WriteLine("\nОбщие подписчики:");
            foreach (var email in commonSubscribers)
            {
                Console.WriteLine($"- {email}");
            }

            bool removed = subscribers.Remove("charlie@example.com");
            Console.WriteLine($"\nУдалили charlie@example.com? {removed}");

            Console.WriteLine($"Всего подписчиков: {subscribers.Count}");

            HashSet<string> testGroup = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
            {
                "alice@example.com",
                "bob@example.com"
            };
            Console.WriteLine($"testGroup является подмножеством? {testGroup.IsSubsetOf(subscribers)}");

            subscribers.Clear();
            Console.WriteLine($"Подписчиков после очистки: {subscribers.Count}");

            Console.ReadKey();
        }
    }
}
