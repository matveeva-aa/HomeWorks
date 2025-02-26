namespace Task2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите 3 целых числа через запятую (a, b, c): ");

            string[] input = Console.ReadLine().Split(", ");
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            int c = int.Parse(input[2]);
            (a, b, c) = (c, a, b);

            Console.WriteLine($"Результат: a = {a}, b = {b}, c = {c}");
            Console.ReadKey();     
        }
    }
}
