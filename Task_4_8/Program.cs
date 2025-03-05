namespace Task_4_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число n: ");
            int n = int.Parse(Console.ReadLine());

            bool negativeIsTrue = n < 0;
            n = (Math.Abs(n));
            int a = 0;
            do
            {
                int b = n % 10;
                a = a * 10 + b;
                n /= 10;
                
            } while (n > 0);
            if (negativeIsTrue)
            {
                a = -a;
            }

            Console.WriteLine($"Зеркальное число: {a}");
            Console.ReadKey();
        }
    }
}
