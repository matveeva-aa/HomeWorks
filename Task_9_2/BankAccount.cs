using System;

namespace Task_9_2
{
    class BankAccount
    {
        private decimal _balance;
        private static int _totalAccounts;

        public int AccountNumber { get; }
        public decimal Balance { get; private set; }

        private static Random _random = new Random();

        public BankAccount()
        {
            _totalAccounts++;
            AccountNumber = _random.Next(1000, 10000);
            Balance = 0;
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Сумма пополнения должна быть больше 0");

            _balance += amount;
            Balance = _balance;
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Сумма снятия должна быть больше 0");

            if (amount > _balance)
                throw new InvalidOperationException("Недостаточно средств на счете");

            _balance -= amount;
            Balance = _balance;
        }

        public static void ShowTotalAccounts()
        {
            Console.WriteLine($"Общее количество созданных счетов: {_totalAccounts}");
        }
    }
}
