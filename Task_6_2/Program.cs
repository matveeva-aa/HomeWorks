namespace Task_6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите предложение: ");
            string input = Console.ReadLine();

            string cleaned = input.Replace(" ", "").ToLower();

            char[] reversedArray = cleaned.ToCharArray();
            Array.Reverse(reversedArray);
            string reversed = new string(reversedArray);

            if (cleaned == reversed)
                Console.WriteLine("Это палиндром");
            else
                Console.WriteLine("Это не палиндром");

            Console.ReadKey();
        }
    }
} 