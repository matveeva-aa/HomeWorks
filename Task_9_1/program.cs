using System;

namespace Task_9_1
{

    class Program
    {
        static void Main()
        {
            Book book = new Book("Война и мир", "Л. Толстой", 1869, 1225);
            Console.WriteLine(book.GetInfo());

            Console.ReadKey();
        }
    }
}
