using System;

namespace Task20
{
    class Animal
    {
        public virtual void Eat()
        {
            Console.WriteLine("Животное ест");
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("Животное издает звук");
        }
    }

    class Lion : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Лев ест мясо");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Лев: Р-р-р!");
        }
    }

    class Elephant : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Слон ест траву");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Слон трубит");
        }
    }

    class Monkey : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Обезьяна ест бананы");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Обезьяна кричит");
        }
    }

    class Tiger : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Тигр ест мясо");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Тигр рычит");
        }
    }

    class Penguin : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Пингвин ест рыбу");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Пингвин издает звук");
        }
    }

    class Program
    {
        static void Main()
        {
            Animal[] animals =
            {
                new Lion(),
                new Elephant(),
                new Monkey(),
                new Tiger(),
                new Penguin()
            };

            foreach (Animal animal in animals)
            {
                animal.Eat();
                animal.MakeSound();
            }
        }
    }
}