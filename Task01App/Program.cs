using System;

namespace Task01
{
    class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("Животное издает звук");
        }
    }

    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Собака: Гав-гав!");
        }
    }

    class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Кошка: Мяу!");
        }
    }

    class Program
    {
        static void Main()
        {
            Animal[] animals = { new Dog(), new Cat() };

            foreach (var animal in animals)
            {
                animal.Speak();
            }
        }
    }
}