using System;
using System.Collections.Generic;

namespace Task30
{
    abstract class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public double Price { get; set; }
        public double MaxSpeed { get; set; }

        public Vehicle(
            string brand,
            string model,
            double price,
            double maxSpeed)
        {
            Brand = brand;
            Model = model;
            Price = price;
            MaxSpeed = maxSpeed;
        }

        public abstract double GetFuelConsumption();

        public virtual void Move()
        {
            Console.WriteLine(
                $"{Brand} {Model} движется.");
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine(
                $"Марка: {Brand}, " +
                $"модель: {Model}, " +
                $"цена: {Price}, " +
                $"максимальная скорость: {MaxSpeed} км/ч, " +
                $"расход: {GetFuelConsumption()} л/100 км");
        }
    }


    class Car : Vehicle
    {
        public int Doors { get; set; }

        public Car(
            string brand,
            string model,
            double price,
            double maxSpeed,
            int doors)
            : base(brand, model, price, maxSpeed)
        {
            Doors = doors;
        }

        public override double GetFuelConsumption()
        {
            return 8.0;
        }

        public override void Move()
        {
            Console.WriteLine(
                $"{Brand} {Model} едет по дороге.");
        }

        public override void ShowInfo()
        {
            base.ShowInfo();

            Console.WriteLine(
                $"Количество дверей: {Doors}");
        }
    }


    class Truck : Vehicle
    {
        public double LoadCapacity { get; set; }

        public Truck(
            string brand,
            string model,
            double price,
            double maxSpeed,
            double loadCapacity)
            : base(brand, model, price, maxSpeed)
        {
            LoadCapacity = loadCapacity;
        }

        public override double GetFuelConsumption()
        {
            return 22.0;
        }

        public override void Move()
        {
            Console.WriteLine(
                $"{Brand} {Model} перевозит груз.");
        }

        public override void ShowInfo()
        {
            base.ShowInfo();

            Console.WriteLine(
                $"Грузоподъемность: {LoadCapacity} тонн");
        }
    }


    class Bus : Vehicle
    {
        public int PassengerCapacity { get; set; }

        public Bus(
            string brand,
            string model,
            double price,
            double maxSpeed,
            int passengerCapacity)
            : base(brand, model, price, maxSpeed)
        {
            PassengerCapacity = passengerCapacity;
        }

        public override double GetFuelConsumption()
        {
            return 18.0;
        }

        public override void Move()
        {
            Console.WriteLine(
                $"{Brand} {Model} перевозит пассажиров.");
        }

        public override void ShowInfo()
        {
            base.ShowInfo();

            Console.WriteLine(
                $"Вместимость: {PassengerCapacity} пассажиров");
        }
    }


    class ElectricCar : Vehicle
    {
        public double BatteryCapacity { get; set; }

        public ElectricCar(
            string brand,
            string model,
            double price,
            double maxSpeed,
            double batteryCapacity)
            : base(brand, model, price, maxSpeed)
        {
            BatteryCapacity = batteryCapacity;
        }

        public override double GetFuelConsumption()
        {
            return 0;
        }

        public override void Move()
        {
            Console.WriteLine(
                $"{Brand} {Model} движется на электричестве.");
        }

        public override void ShowInfo()
        {
            Console.WriteLine(
                $"Марка: {Brand}, " +
                $"модель: {Model}, " +
                $"цена: {Price}, " +
                $"максимальная скорость: {MaxSpeed} км/ч");

            Console.WriteLine(
                $"Электромобиль, батарея: {BatteryCapacity} кВт·ч");
        }
    }


    class Motorcycle : Vehicle
    {
        public bool HasSidecar { get; set; }

        public Motorcycle(
            string brand,
            string model,
            double price,
            double maxSpeed,
            bool hasSidecar)
            : base(brand, model, price, maxSpeed)
        {
            HasSidecar = hasSidecar;
        }

        public override double GetFuelConsumption()
        {
            return 4.5;
        }

        public override void Move()
        {
            Console.WriteLine(
                $"{Brand} {Model} движется на двух колесах.");
        }

        public override void ShowInfo()
        {
            base.ShowInfo();

            Console.WriteLine(
                $"Боковой прицеп: {HasSidecar}");
        }
    }


    class Fleet
    {
        private List<Vehicle> vehicles;

        public Fleet()
        {
            vehicles = new List<Vehicle>();
        }


        // Добавление транспорта
        public void AddVehicle(Vehicle vehicle)
        {
            vehicles.Add(vehicle);

            Console.WriteLine(
                $"Добавлен: {vehicle.Brand} {vehicle.Model}");
        }


        // Удаление транспорта
        public void RemoveVehicle(Vehicle vehicle)
        {
            if (vehicles.Remove(vehicle))
            {
                Console.WriteLine(
                    $"Удален: {vehicle.Brand} {vehicle.Model}");
            }
            else
            {
                Console.WriteLine("Транспорт не найден.");
            }
        }


        // Вывод информации
        public void ShowAll()
        {
            Console.WriteLine("\n===== Автопарк =====");

            foreach (Vehicle vehicle in vehicles)
            {
                vehicle.ShowInfo();
                Console.WriteLine();
            }
        }


        // Самый быстрый транспорт
        public Vehicle? GetFastestVehicle()
        {
            if (vehicles.Count == 0)
            {
                return null;
            }

            Vehicle fastest = vehicles[0];

            foreach (Vehicle vehicle in vehicles)
            {
                if (vehicle.MaxSpeed > fastest.MaxSpeed)
                {
                    fastest = vehicle;
                }
            }

            return fastest;
        }


        // Самый дорогой транспорт
        public Vehicle? GetMostExpensiveVehicle()
        {
            if (vehicles.Count == 0)
            {
                return null;
            }

            Vehicle expensive = vehicles[0];

            foreach (Vehicle vehicle in vehicles)
            {
                if (vehicle.Price > expensive.Price)
                {
                    expensive = vehicle;
                }
            }

            return expensive;
        }


        // Показать расход топлива
        public void ShowFuelConsumption()
        {
            Console.WriteLine("\n===== Расход топлива =====");

            foreach (Vehicle vehicle in vehicles)
            {
                Console.WriteLine(
                    $"{vehicle.Brand} {vehicle.Model}: " +
                    $"{vehicle.GetFuelConsumption()} л/100 км");
            }
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
            Fleet fleet = new Fleet();


            // Создаем транспорт
            Car car = new Car(
                "Toyota",
                "Camry",
                15000000,
                220,
                4);

            Truck truck = new Truck(
                "Volvo",
                "FH",
                35000000,
                160,
                20);

            Bus bus = new Bus(
                "Mercedes",
                "Sprinter",
                25000000,
                150,
                30);

            ElectricCar electricCar = new ElectricCar(
                "Tesla",
                "Model 3",
                22000000,
                250,
                75);

            Motorcycle motorcycle = new Motorcycle(
                "Yamaha",
                "R1",
                9000000,
                299,
                false);


            // Добавляем транспорт
            fleet.AddVehicle(car);
            fleet.AddVehicle(truck);
            fleet.AddVehicle(bus);
            fleet.AddVehicle(electricCar);
            fleet.AddVehicle(motorcycle);


            // Выводим весь автопарк
            fleet.ShowAll();


            // Расход топлива
            fleet.ShowFuelConsumption();


            // Самый быстрый
            Vehicle? fastest = fleet.GetFastestVehicle();

            if (fastest != null)
            {
                Console.WriteLine(
                    "\nСамый быстрый транспорт: " +
                    $"{fastest.Brand} {fastest.Model}, " +
                    $"{fastest.MaxSpeed} км/ч");
            }


            // Самый дорогой
            Vehicle? expensive =
                fleet.GetMostExpensiveVehicle();

            if (expensive != null)
            {
                Console.WriteLine(
                    "Самый дорогой транспорт: " +
                    $"{expensive.Brand} {expensive.Model}, " +
                    $"{expensive.Price} тг");
            }


            // Удаляем транспорт
            fleet.RemoveVehicle(bus);

            Console.WriteLine(
                "\nПосле удаления автобуса:");

            fleet.ShowAll();
        }
    }
}