using System;

namespace Task25
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Introduce()
        {
            Console.WriteLine(
                $"Меня зовут {Name}, мне {Age} лет.");
        }
    }

    class Employee : Person
    {
        public string Position { get; set; }
        public double Salary { get; set; }

        public Employee(
            string name,
            int age,
            string position,
            double salary)
            : base(name, age)
        {
            Position = position;
            Salary = salary;
        }

        public void Work()
        {
            Console.WriteLine(
                $"{Name} работает на должности {Position}.");
        }
    }

    class Manager : Employee
    {
        public int TeamSize { get; set; }
        public string Department { get; set; }

        public Manager(
            string name,
            int age,
            string position,
            double salary,
            int teamSize,
            string department)
            : base(name, age, position, salary)
        {
            TeamSize = teamSize;
            Department = department;
        }

        public void ManageTeam()
        {
            Console.WriteLine(
                $"{Name} управляет командой из {TeamSize} человек.");
        }
    }

    class Director : Manager
    {
        public string Company { get; set; }
        public int Departments { get; set; }

        public Director(
            string name,
            int age,
            string position,
            double salary,
            int teamSize,
            string department,
            string company,
            int departments)
            : base(
                name,
                age,
                position,
                salary,
                teamSize,
                department)
        {
            Company = company;
            Departments = departments;
        }

        public void ManageCompany()
        {
            Console.WriteLine(
                $"{Name} руководит компанией {Company}.");
        }
    }

    class Program
    {
        static void Main()
        {
            Director director = new Director(
                "Елена",
                45,
                "Директор",
                250000,
                12,
                "Разработка",
                "Техно",
                4);

            director.Introduce();
            director.Work();
            director.ManageTeam();
            director.ManageCompany();
        }
    }
}