namespace Task_3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Введите третье число: ");
            int c = int.Parse(Console.ReadLine());

            Console.Write("Введите четвертое число: ");
            int d = int.Parse(Console.ReadLine());

            int max = Math.Max(Math.Max(a, b), Math.Max(c, d));

            Console.WriteLine($"Наибольшее число: {max}");
            Console.ReadKey();
        }
    }
}
