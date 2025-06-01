using System;

namespace Task_9_2
{
    class Program
    {
        static void Main()
        {
            BankAccount acc1 = new BankAccount();
            BankAccount acc2 = new BankAccount();

            try
            {
                acc1.Deposit(400);
                acc1.Withdraw(300);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Ошибка при пополнении: " + ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("Ошибка при снятии: " + ex.Message);
            }

            Console.WriteLine($"Счет: {acc1.AccountNumber}, Баланс: {acc1.Balance} р.");
            Console.WriteLine($"Счет: {acc2.AccountNumber}, Баланс: {acc2.Balance} р.");
            BankAccount.ShowTotalAccounts();

            Console.ReadKey();
        }
    }
}
