namespace Task_3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");
            double b = double.Parse(Console.ReadLine());

            char sign = (a > b) ? '>' : (a < b) ? '<' : '=';

            Console.WriteLine($"{a} {sign} {b}");
            Console.ReadKey();
        }
    }
}
