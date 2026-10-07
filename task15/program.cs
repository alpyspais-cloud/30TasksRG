using System;

namespace Task15
{
    class MilitaryVehicle
    {
        public virtual void Attack()
        {
            Console.WriteLine("Военная техника атакует");
        }
    }

    class Tank : MilitaryVehicle
    {
        public override void Attack()
        {
            Console.WriteLine("Танк атакует из пушки");
        }
    }

    class Helicopter : MilitaryVehicle
    {
        public override void Attack()
        {
            Console.WriteLine("Вертолет атакует ракетами");
        }
    }

    class ArmoredCar : MilitaryVehicle
    {
        public override void Attack()
        {
            Console.WriteLine("Бронемашина атакует из пулемета");
        }
    }

    class Program
    {
        static void Main()
        {
            MilitaryVehicle[] vehicles =
            {
                new Tank(),
                new Helicopter(),
                new ArmoredCar()
            };

            foreach (MilitaryVehicle vehicle in vehicles)
            {
                vehicle.Attack();
            }
        }
    }
}