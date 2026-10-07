namespace Task13
{
    class Employee
    {
        public string Name { get; set; }

        public Employee(string name)
        {
            Name = name;
        }

        public virtual double GetSalary()
        {
            return 0;
        }
    }

    class Programmer : Employee
    {
        public double Hours { get; set; }
        public double HourRate { get; set; }

        public Programmer(
            string name,
            double hours,
            double hourRate)
            : base(name)
        {
            Hours = hours;
            HourRate = hourRate;
        }

        public override double GetSalary()
        {
            return Hours * HourRate;
        }
    }

    class Designer : Employee
    {
        public int Projects { get; set; }
        public double PaymentPerProject { get; set; }

        public Designer(
            string name,
            int projects,
            double paymentPerProject)
            : base(name)
        {
            Projects = projects;
            PaymentPerProject = paymentPerProject;
        }

        public override double GetSalary()
        {
            return Projects * PaymentPerProject;
        }
    }

    class Manager : Employee
    {
        public double BaseSalary { get; set; }
        public double Bonus { get; set; }

        public Manager(
            string name,
            double baseSalary,
            double bonus)
            : base(name)
        {
            BaseSalary = baseSalary;
            Bonus = bonus;
        }

        public override double GetSalary()
        {
            return BaseSalary + Bonus;
        }
    }

    class Program
    {
        static void Main()
        {
            Employee[] employees =
            {
                new Programmer("Иван", 160, 1000),
                new Designer("Анна", 4, 25000),
                new Manager("Олег", 100000, 20000)
            };

            foreach (Employee employee in employees)
            {
                Console.WriteLine($"{employee.Name}: зарплата {employee.GetSalary()}");
            }
        }
    }
}