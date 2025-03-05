namespace Task_3_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину участка (a): ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите ширину участка (b): ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Введите длину первого дома (p): ");
            int p = int.Parse(Console.ReadLine());

            Console.Write("Введите ширину первого дома (q): ");
            int q = int.Parse(Console.ReadLine());

            Console.Write("Введите длину второго дома (r): ");
            int r = int.Parse(Console.ReadLine());

            Console.Write("Введите ширину второго дома (s): ");
            int s = int.Parse(Console.ReadLine());

            bool place =
                (p + r <= a && Math.Max(q, s) <= b) || (Math.Max(p, r) <= a && q + s <= b) ||
                (p + s <= a && Math.Max(q, r) <= b) || (Math.Max(p, s) <= a && q + r <= b) ||
                (q + r <= a && Math.Max(p, s) <= b) || (Math.Max(q, r) <= a && p + s <= b) ||
                (q + s <= a && Math.Max(p, r) <= b) || (Math.Max(q, s) <= a && p + r <= b);

            Console.WriteLine(place ? "Да" : "Нет");
            Console.ReadKey();
        }
    }
}
