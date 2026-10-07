using System;

namespace Task16
{
    class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Damage { get; set; }

        public Character(
            string name,
            int health,
            int damage)
        {
            Name = name;
            Health = health;
            Damage = damage;
        }

        public virtual void Attack()
        {
            Console.WriteLine(
                $"{Name} атакует и наносит {Damage} урона");
        }
    }

    class Warrior : Character
    {
        public Warrior(
            string name,
            int health,
            int damage)
            : base(name, health, damage)
        {
        }

        public override void Attack()
        {
            Console.WriteLine(
                $"{Name} атакует мечом и наносит {Damage} урона");
        }
    }

    class Mage : Character
    {
        public Mage(
            string name,
            int health,
            int damage)
            : base(name, health, damage)
        {
        }

        public override void Attack()
        {
            Console.WriteLine(
                $"{Name} использует магию и наносит {Damage * 2} урона");
        }
    }

    class Archer : Character
    {
        public Archer(
            string name,
            int health,
            int damage)
            : base(name, health, damage)
        {
        }

        public override void Attack()
        {
            Console.WriteLine(
                $"{Name} стреляет из лука и наносит {Damage} урона");
        }
    }

    class Program
    {
        static void Main()
        {
            Character[] characters =
            {
                new Warrior("Воин", 100, 20),
                new Mage("Маг", 70, 15),
                new Archer("Лучник", 80, 18)
            };

            foreach (Character character in characters)
            {
                character.Attack();
            }
        }
    }
}