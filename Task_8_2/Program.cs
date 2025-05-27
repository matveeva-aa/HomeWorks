using System;

namespace Task_8_2
{
    class Program
    {
        static void Main()
        {
            try
            {
                Console.Write("Введите возраст: ");
                int age = Convert.ToInt32(Console.ReadLine());

                ValidateAge(age);

                Console.WriteLine("Возраст корректный");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }

            Console.ReadKey();
        }

        static void ValidateAge(int age)
        {
            if (age < 0)
                throw new ArgumentException("Возраст не может быть отрицательным");

            if (age > 150)
                throw new ArgumentOutOfRangeException(null, "Слишком большой возраст");
        }
    }
}
