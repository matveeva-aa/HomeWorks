using System;

namespace Task_11_1
{
    class Program
    {
        static void Main()
        {
            Animal[] animals = new Animal[]
            {
                new Dog(),
                new Cat()
            };

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.ShowInfo());
            }

            Console.ReadKey();
        }
    }
}
