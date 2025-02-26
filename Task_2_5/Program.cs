namespace Task_2_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину трубы в метрах: ");
            double length = double.Parse(Console.ReadLine());

            int roundedLength = (int)Math.Ceiling(length);

            Console.WriteLine(roundedLength);
            Console.ReadKey();
        }
    }
}
