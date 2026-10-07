namespace Task19
{
    class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }

        public virtual double GetBonus()
        {
            return 0;
        }

        public double GetTotalSalary()
        {
            return Salary + GetBonus();
        }
    }

    class Manager : Employee
    {
        public Manager(string name, double salary)
            : base(name, salary)
        {
        }

        public override double GetBonus()
        {
            return Salary * 0.20;
        }
    }

    class Developer : Employee
    {
        public Developer(string name, double salary)
            : base(name, salary)
        {
        }

        public override double GetBonus()
        {
            return Salary * 0.15;
        }
    }

    class SalesManager : Employee
    {
        public SalesManager(string name, double salary)
            : base(name, salary)
        {
        }

        public override double GetBonus()
        {
            return Salary * 0.25;
        }
    }

    class Program
    {
        static void Main()
        {
            Employee[] employees =
            {
                new Manager("Иван", 100000),
                new Developer("Анна", 120000),
                new SalesManager("Олег", 90000)
            };

            foreach (Employee employee in employees)
            {
                Console.WriteLine($"{employee.Name}: итоговая зарплата {employee.GetTotalSalary()}");
            }
        }
    }
}