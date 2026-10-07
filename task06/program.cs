using System;

namespace Task06
{
    class Vehicle
    {
        public virtual void Move()
        {
            Console.WriteLine("Транспорт движется");
        }
    }

    class Car : Vehicle
    {
        public override void Move()
        {
            Console.WriteLine("Машина едет по дороге");
        }
    }

    class Bus : Vehicle
    {
        public override void Move()
        {
            Console.WriteLine("Автобус едет по маршруту");
        }
    }

    class Train : Vehicle
    {
        public override void Move()
        {
            Console.WriteLine("Поезд движется по рельсам");
        }
    }

    class Program
    {
        static void Main()
        {
            Vehicle[] vehicles =
            {
                new Car(),
                new Bus(),
                new Train()
            };

            foreach (Vehicle vehicle in vehicles)
            {
                vehicle.Move();
            }
        }
    }
}