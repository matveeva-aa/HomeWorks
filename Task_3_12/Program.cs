namespace Task_3_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число (100-999): ");
            int number = int.Parse(Console.ReadLine());

            if (number < 100 || number > 999)
            {
                Console.WriteLine("Ошибка! Число не соответствует диапазону");
                Console.ReadKey();
                return;
            }

            int hundreds = number / 100;
            int tens = (number / 10) % 10;
            int ones = number % 10;

            string[] hundredsText = { "сто", "двести", "триста", "четыреста", "пятьсот",
                                  "шестьсот", "семьсот", "восемьсот", "девятьсот" };
            string[] tensText = { "", "десять", "двадцать", "тридцать", "сорок", "пятьдесят",
                              "шестьдесят", "семьдесят", "восемьдесят", "девяносто" };
            string[] tensText2 = { "десять", "одиннадцать", "двенадцать", "тринадцать",
                               "четырнадцать", "пятнадцать", "шестнадцать", "семнадцать",
                               "восемнадцать", "девятнадцать" };
            string[] onesText = { "", "один", "два", "три", "четыре", "пять", "шесть",
                              "семь", "восемь", "девять" };

            string result = hundredsText[hundreds - 1] + " ";

            if (tens == 1)
            {
                result += tensText2[ones];
            }
            else
            {
                result += tensText[tens] + " " + onesText[ones];
            }

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
