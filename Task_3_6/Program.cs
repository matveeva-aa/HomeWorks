namespace Task_3_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int number = int.Parse(Console.ReadLine());

            string result = (number % 2 == 0) ? "Да" : "Нет";

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
