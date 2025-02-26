namespace Task_3_4
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

            int median = a + b + c - Math.Max(a, Math.Max(b, c)) - Math.Min(a, Math.Min(b, c));

            Console.WriteLine($"Медиана: {median}");
            Console.ReadKey();
        }
    }
}
