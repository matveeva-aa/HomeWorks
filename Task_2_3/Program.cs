namespace Task_2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину в дюймах: ");
            double inches = double.Parse(Console.ReadLine());

            double totalLength = inches * 2.54;

            int meters = (int)(totalLength / 100);
            int centimeters = (int)(totalLength % 100);
            int millimeters = (int)Math.Round((totalLength % 1) * 10);

            Console.WriteLine($"Результат: {meters} м {centimeters} см {millimeters} мм");
            Console.ReadKey();
        }
    }
}
