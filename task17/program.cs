using System;

namespace Task17
{
    class Device
    {
        public virtual void TurnOn()
        {
            Console.WriteLine("Устройство включено");
        }

        public virtual void TurnOff()
        {
            Console.WriteLine("Устройство выключено");
        }
    }

    class Phone : Device
    {
        public override void TurnOn()
        {
            Console.WriteLine("Телефон включается");
        }

        public override void TurnOff()
        {
            Console.WriteLine("Телефон выключается");
        }
    }

    class Computer : Device
    {
        public override void TurnOn()
        {
            Console.WriteLine("Компьютер загружается");
        }

        public override void TurnOff()
        {
            Console.WriteLine("Компьютер выключается");
        }
    }

    class Television : Device
    {
        public override void TurnOn()
        {
            Console.WriteLine("Телевизор включается");
        }

        public override void TurnOff()
        {
            Console.WriteLine("Телевизор выключается");
        }
    }

    class Program
    {
        static void Main()
        {
            Device[] devices = { new Phone(), new Computer(), new Television() };

            foreach (Device device in devices)
            {
                device.TurnOn();
                device.TurnOff();
            }
        }
    }
}