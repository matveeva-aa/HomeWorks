namespace Task_2_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину трубы в метрах: ");
            double length = double.Parse(Console.ReadLine());

            double roundedLength = Math.Round(length * 2) / 2;

            Console.WriteLine(roundedLength);
            Console.ReadKey();
        }
    }
}
