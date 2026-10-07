using System;

namespace Task11
{
    class BankAccount
    {
        public double Balance { get; protected set; }

        public BankAccount(double balance)
        {
            Balance = balance;
        }

        public virtual void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"Пополнено: {amount}");
            }
        }

        public virtual void Withdraw(double amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"Снято: {amount}");
            }
            else
            {
                Console.WriteLine("Недостаточно средств");
            }
        }

        public void ShowBalance()
        {
            Console.WriteLine($"Баланс: {Balance}");
        }
    }

    class SavingsAccount : BankAccount
    {
        public double InterestRate { get; set; }

        public SavingsAccount(
            double balance,
            double interestRate)
            : base(balance)
        {
            InterestRate = interestRate;
        }

        public void AddInterest()
        {
            Balance += Balance * InterestRate / 100;
            Console.WriteLine("Начислены проценты");
        }
    }

    class CreditAccount : BankAccount
    {
        public double CreditLimit { get; set; }

        public CreditAccount(
            double balance,
            double creditLimit)
            : base(balance)
        {
            CreditLimit = creditLimit;
        }

        public override void Withdraw(double amount)
        {
            if (amount > 0 &&
                amount <= Balance + CreditLimit)
            {
                Balance -= amount;
                Console.WriteLine($"Снято: {amount}");
            }
            else
            {
                Console.WriteLine("Превышен кредитный лимит");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            SavingsAccount savings = new SavingsAccount(10000, 5);
            savings.AddInterest();
            savings.ShowBalance();

            CreditAccount credit = new CreditAccount(1000, 500);
            credit.Withdraw(1200);
            credit.ShowBalance();
        }
    }
}