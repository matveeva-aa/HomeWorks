using System;

namespace Task_11_2
{
    class Program
    {
        static void Main()
        {
            IFlyable[] flyers = new IFlyable[]
            {
                new Bird(100),
                new Airplane(10000, 360)
            };

            foreach (var flyer in flyers)
            {
                flyer.Fly();
            }

            Console.ReadKey();
        }
    }
}
