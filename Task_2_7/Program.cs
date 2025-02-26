namespace Task_2_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое целое число a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите второе целое число b: ");
            int b = int.Parse(Console.ReadLine());

            (a, b) = (b, a);

            Console.WriteLine($"После обмена: a = {a}, b = {b}");
            Console.ReadKey();
        }
    }
}
