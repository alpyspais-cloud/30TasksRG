using System;

namespace Task26
{
    abstract class Character
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

        public abstract void Attack();

        public abstract void Defend();

        public abstract void SpecialAttack();
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
                $"{Name} атакует мечом.");
        }

        public override void Defend()
        {
            Console.WriteLine(
                $"{Name} защищается щитом.");
        }

        public override void SpecialAttack()
        {
            Console.WriteLine(
                $"{Name} использует мощный удар.");
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
                $"{Name} атакует магическим заклинанием.");
        }

        public override void Defend()
        {
            Console.WriteLine(
                $"{Name} создает магический щит.");
        }

        public override void SpecialAttack()
        {
            Console.WriteLine(
                $"{Name} использует огненный шар.");
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
                $"{Name} стреляет из лука.");
        }

        public override void Defend()
        {
            Console.WriteLine(
                $"{Name} уклоняется от атаки.");
        }

        public override void SpecialAttack()
        {
            Console.WriteLine(
                $"{Name} выпускает град стрел.");
        }
    }

    class Program
    {
        static void Main()
        {
            Character[] characters =
            {
                new Warrior("Воин", 100, 20),
                new Mage("Маг", 70, 30),
                new Archer("Лучник", 80, 18)
            };

            foreach (Character character in characters)
            {
                character.Attack();
                character.Defend();
                character.SpecialAttack();
            }
        }
    }
}