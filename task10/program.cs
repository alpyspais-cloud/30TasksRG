using System;

namespace Task10
{
    class Pet
    {
        public virtual void Eat()
        {
            Console.WriteLine("Животное ест");
        }
    }

    class Dog : Pet
    {
        public override void Eat()
        {
            Console.WriteLine("Собака ест корм");
        }
    }

    class Cat : Pet
    {
        public override void Eat()
        {
            Console.WriteLine("Кошка ест рыбу");
        }
    }

    class Parrot : Pet
    {
        public override void Eat()
        {
            Console.WriteLine("Попугай ест зерно");
        }
    }

    class Program
    {
        static void Main()
        {
            Pet[] pets = { new Dog(), new Cat(), new Parrot() };

            foreach (Pet pet in pets)
            {
                pet.Eat();
            }
        }
    }
}