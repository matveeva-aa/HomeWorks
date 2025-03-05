namespace Task_3_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int number = int.Parse(Console.ReadLine());

            string result = (number >= 10 && number <= 99) || (number <= -10 && number >= -99) ? "Да" : "Нет";

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
