using System;

namespace Task_12_1
{
    class Program
    {
        static void Main()
        {
            var books1 = new Book<string, int>[]
            {
                new Book<string, int>("F-1234", "Война и мир", 1867, "Толстой"),
                new Book<string, int>("F-5678", "Преступление и наказание", 1866, "Достоевский")
            };

            var books2 = new Book<int, string>[]
            {
                new Book<int, string>(42, "Ромео и Джульетта", "XVI век", "Шекспир"),
                new Book<int, string>(73, "Божественная Комедия", "XIV век", "Данте")
            };

            var foundBook1 = BookFinder.FindBook(books1, "F-1234");

            if (foundBook1 != null)
                Console.WriteLine(foundBook1.ToString());
            else
                Console.WriteLine("Книга с кодом F-1234 не найдена.");

            var foundBook2 = BookFinder.FindBook(books2, 42);

            if (foundBook2 != null)
                Console.WriteLine(foundBook2.ToString());
            else
                Console.WriteLine("Книга с кодом 42 не найдена.");

            Console.ReadKey();
        }
    }
}
