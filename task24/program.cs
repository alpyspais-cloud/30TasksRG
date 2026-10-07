using System;

namespace Task24
{
    class MedicalWorker
    {
        public string Name { get; set; }

        public MedicalWorker(string name)
        {
            Name = name;
        }

        public virtual void Work()
        {
            Console.WriteLine($"{Name} работает в больнице");
        }
    }

    class Doctor : MedicalWorker
    {
        public Doctor(string name)
            : base(name)
        {
        }

        public override void Work()
        {
            Console.WriteLine(
                $"Доктор {Name} осматривает пациентов");
        }
    }

    class Nurse : MedicalWorker
    {
        public Nurse(string name)
            : base(name)
        {
        }

        public override void Work()
        {
            Console.WriteLine(
                $"Медсестра {Name} ухаживает за пациентами");
        }
    }

    class Surgeon : MedicalWorker
    {
        public Surgeon(string name)
            : base(name)
        {
        }

        public override void Work()
        {
            Console.WriteLine(
                $"Хирург {Name} проводит операцию");
        }
    }

    class Program
    {
        static void Main()
        {
            MedicalWorker[] workers =
            {
                new Doctor("Иван"),
                new Nurse("Анна"),
                new Surgeon("Олег")
            };

            foreach (MedicalWorker worker in workers)
            {
                worker.Work();
            }
        }
    }
}