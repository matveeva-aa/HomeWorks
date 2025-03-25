namespace Task_6_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите месяц: ");
            string month = Console.ReadLine();

            Console.Write("Введите год: ");
            int year = int.Parse(Console.ReadLine());

            Console.Write("Введите общую сумму продаж: ");
            double totalSales = double.Parse(Console.ReadLine());

            Console.Write("Введите количество проданных товаров: ");
            int totalSold = int.Parse(Console.ReadLine());

            double mPrice = totalSales / totalSold;

            string totalSales2 = totalSales.ToString("N2") + " р.";
            string totalSold2 = totalSold.ToString("N0") + " шт.";
            string mPrice2 = mPrice.ToString("N2") + " р.";

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Отчёт о продажах за {month} {year}");
            Console.WriteLine();
            Console.WriteLine($"Общая сумма продаж: {totalSales2}");
            Console.WriteLine($"Количество проданных товаров: {totalSold2}");
            Console.WriteLine($"Средняя стоимость товара: {mPrice2}");

            Console.ReadKey();
        }
    }
}