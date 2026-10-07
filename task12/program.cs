namespace Task12
{
    class Transport
    {
        public virtual double CalculateCost(double distance)
        {
            return 0;
        }
    }

    class Car : Transport
    {
        public override double CalculateCost(double distance)
        {
            return distance * 50;
        }
    }

    class Truck : Transport
    {
        public override double CalculateCost(double distance)
        {
            return distance * 100;
        }
    }

    class Bus : Transport
    {
        public override double CalculateCost(double distance)
        {
            return distance * 70;
        }
    }

    class Program
    {
        static void Main()
        {
            const double distance = 100;
            Transport[] transports = { new Car(), new Truck(), new Bus() };

            foreach (Transport transport in transports)
            {
                Console.WriteLine($"{transport.GetType().Name}: стоимость поездки на {distance} км — {transport.CalculateCost(distance)}");
            }
        }
    }
}