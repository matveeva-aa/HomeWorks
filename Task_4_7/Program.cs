namespace Task_4_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число n: ");
            int n = int.Parse(Console.ReadLine());

            int startN = n;
            n = (Math.Abs(n));
            int a = 0;
            do
            {
                a++;
                n /= 10;
            } while (n > 0);

            Console.WriteLine($"{startN}: {a} шт.");
            Console.ReadKey();
        }
    }
}
