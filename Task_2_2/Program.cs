namespace Task_2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите градусы: ");
            int degrees = int.Parse(Console.ReadLine());

            Console.Write("Введите минуты: ");
            int minutes = int.Parse(Console.ReadLine());

            Console.Write("Введите секунды: ");
            int seconds = int.Parse(Console.ReadLine());

            double decimalDegrees = degrees + (minutes / 60.0) + (seconds / 3600.0);
            double radians = decimalDegrees * Math.PI / 180;

            Console.WriteLine($"Угол в радианах: {radians}");
            Console.ReadKey();
        }
    }
}
