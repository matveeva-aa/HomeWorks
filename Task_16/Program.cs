using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Task_16
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("=== Способ 1: задачи-продолжения (ContinueWith) ===");

            Task<int[]> generateTask = GenerateArrayAsync();
            Task continueTask = generateTask.ContinueWith(arrayTask =>
            {
                Task<double> avgTask = CalculateAverageAsync(arrayTask.Result);
                avgTask.ContinueWith(avg =>
                {
                    Console.WriteLine($"Среднее значение: {avg.Result:F2}");
                }).Wait();
            });

            continueTask.Wait();

            Console.WriteLine("\n=== Способ 2: async/await ===");

            RunAsync().Wait();

            Console.ReadKey();
        }

        static Task<int[]> GenerateArrayAsync()
        {
            return Task.Run(() =>
            {
                Console.WriteLine("Создание массива...");
                Thread.Sleep(1000);
                int[] data = Enumerable.Range(1, 10).ToArray();
                Console.WriteLine("Массив создан.");
                return data;
            });
        }

        static Task<double> CalculateAverageAsync(int[] numbers)
        {
            return Task.Run(() =>
            {
                Console.WriteLine("Вычисление среднего...");
                Thread.Sleep(1000);
                return numbers.Average();
            });
        }

        static async Task RunAsync()
        {
            int[] array = await GenerateArrayAsync();
            double average = await CalculateAverageAsync(array);
            Console.WriteLine($"Среднее значение: {average:F2}");
        }
    }
}
