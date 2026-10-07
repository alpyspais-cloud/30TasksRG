using System;
using System.Collections.Generic;

namespace Task29
{
    class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Животное издает звук");
        }
    }

    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Собака: Гав-гав!");
        }
    }

    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Кошка: Мяу!");
        }
    }

    class Cow : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Корова: Му-у!");
        }
    }

    class Lion : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Лев: Р-р-р!");
        }
    }

    class Bird : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Птица: Чик-чирик!");
        }
    }

    class Program
    {
        static void Main()
        {
            Run();
        }

        public static void Run()
        {
            List<Animal> animals = new List<Animal>
            {
                new Dog(),
                new Cat(),
                new Cow(),
                new Lion(),
                new Bird()
            };

            foreach (Animal animal in animals)
            {
                animal.MakeSound();
            }
        }
    }
}