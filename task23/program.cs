using System;

namespace Task23
{
    abstract class Transport
    {
        public string Brand { get; set; }

        public Transport(string brand)
        {
            Brand = brand;
        }

        public abstract void Move();

        public abstract double GetFuelConsumption();
    }

    class Car : Transport
    {
        public Car(string brand)
            : base(brand)
        {
        }

        public override void Move()
        {
            Console.WriteLine($"{Brand} едет по дороге");
        }

        public override double GetFuelConsumption()
        {
            return 7.5;
        }
    }

    class Truck : Transport
    {
        public Truck(string brand)
            : base(brand)
        {
        }

        public override void Move()
        {
            Console.WriteLine($"{Brand} перевозит груз");
        }

        public override double GetFuelConsumption()
        {
            return 20.0;
        }
    }

    class Bus : Transport
    {
        public Bus(string brand)
            : base(brand)
        {
        }

        public override void Move()
        {
            Console.WriteLine($"{Brand} перевозит пассажиров");
        }

        public override double GetFuelConsumption()
        {
            return 15.0;
        }
    }

    class Motorcycle : Transport
    {
        public Motorcycle(string brand)
            : base(brand)
        {
        }

        public override void Move()
        {
            Console.WriteLine($"{Brand} движется на двух колесах");
        }

        public override double GetFuelConsumption()
        {
            return 4.5;
        }
    }

    class Program
    {
        static void Main()
        {
            Transport[] transports =
            {
                new Car("Toyota"),
                new Truck("Volvo"),
                new Bus("Mercedes"),
                new Motorcycle("Yamaha")
            };

            foreach (Transport transport in transports)
            {
                transport.Move();
                Console.WriteLine($"Расход топлива: {transport.GetFuelConsumption()} л/100 км");
            }
        }
    }
}