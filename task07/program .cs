using System;

namespace Task07
{
    class Worker
    {
        public string Name { get; set; }
        public string Position { get; set; }

        public Worker(string name, string position)
        {
            Name = name;
            Position = position;
        }

        public virtual void Work()
        {
            Console.WriteLine($"{Name} работает как {Position}");
        }
    }

    class Cashier : Worker
    {
        public Cashier(string name)
            : base(name, "Кассир")
        {
        }

        public override void Work()
        {
            Console.WriteLine($"{Name} работает на кассе");
        }
    }

    class Seller : Worker
    {
        public Seller(string name)
            : base(name, "Продавец")
        {
        }

        public override void Work()
        {
            Console.WriteLine($"{Name} помогает покупателям");
        }
    }

    class Program
    {
        static void Main()
        {
            Worker[] workers =
            {
                new Cashier("Иван"),
                new Seller("Анна")
            };

            foreach (Worker worker in workers)
            {
                worker.Work();
            }
        }
    }
}