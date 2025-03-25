using System.Text.RegularExpressions;

namespace Task_6_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[!#;%:\?\*]).{14,}$";

            while (true)
            {
                Console.Write("Введите пароль: ");
                string password = Console.ReadLine();

                if (Regex.IsMatch(password, pattern))
                {
                    Console.WriteLine("Пароль подходит");
                    break;
                }
                else
                {
                    Console.WriteLine("Пароль не подходит");
                }
            }

            Console.ReadKey();
        }
    }
}