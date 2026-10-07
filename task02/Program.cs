using System;

namespace Task02
{
    class Vehicle
    {
        public string Brand { get; set; }
        public int Speed { get; set; }

        public Vehicle(string brand, int speed)
        {
            Brand = brand;
            Speed = speed;
        }
    }

    class Car : Vehicle
    {
        public int Doors { get; set; }

        public Car(string brand, int speed, int doors)
            : base(brand, speed)
        {
            Doors = doors;
        }
    }

    class Motorcycle : Vehicle
    {
        public bool HasSidecar { get; set; }

        public Motorcycle(string brand, int speed, bool hasSidecar)
            : base(brand, speed)
        {
            HasSidecar = hasSidecar;
        }
    }

    class Program
    {
        static void Main()
        {
            Car car = new Car("Toyota", 180, 4);
            Motorcycle motorcycle = new Motorcycle("Yamaha", 140, false);

            Console.WriteLine($"Машина: {car.Brand}, скорость: {car.Speed} км/ч, дверей: {car.Doors}");
            Console.WriteLine($"Мотоцикл: {motorcycle.Brand}, скорость: {motorcycle.Speed} км/ч, коляска: {(motorcycle.HasSidecar ? "есть" : "нет")}");
        }
    }
}