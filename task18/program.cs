using System;

namespace Task18
{
    class Payment
    {
        public virtual void Pay(double amount)
        {
            Console.WriteLine($"Оплата: {amount}");
        }
    }

    class CashPayment : Payment
    {
        public override void Pay(double amount)
        {
            Console.WriteLine($"Оплата наличными: {amount}");
        }
    }

    class CardPayment : Payment
    {
        public override void Pay(double amount)
        {
            Console.WriteLine($"Оплата картой: {amount}");
        }
    }

    class OnlinePayment : Payment
    {
        public override void Pay(double amount)
        {
            Console.WriteLine($"Онлайн-оплата: {amount}");
        }
    }

    class Program
    {
        static void Main()
        {
            Payment[] payments =
            {
                new CashPayment(),
                new CardPayment(),
                new OnlinePayment()
            };

            foreach (Payment payment in payments)
            {
                payment.Pay(1500);
            }
        }
    }
}