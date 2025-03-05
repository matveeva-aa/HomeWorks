namespace Task_3_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine((number % 10 == 0) ? "Да" : "Нет");
            Console.ReadKey();
        }
    }
}
