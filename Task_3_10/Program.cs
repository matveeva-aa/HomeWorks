namespace Task_3_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество домов: ");
            int n = int.Parse(Console.ReadLine());

            // Определяем правильное окончание слова "дом"
            string house = (n % 100 >= 11 && n % 100 <= 19) ? "домов" :
                          (n % 10 == 1) ? "дом" :
                          (n % 10 >= 2 && n % 10 <= 4) ? "дома" :
                          "домов";

            // Вывод результата
            Console.WriteLine($"Мы построили {n} {house}");
            Console.ReadKey();
        }
    }
}
