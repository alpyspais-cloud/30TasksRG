using System;
using System.Collections.Generic;

namespace Task28
{
    abstract class Employee
    {
        public string Name { get; set; }

        public Employee(string name)
        {
            Name = name;
        }

        public abstract double CalculateSalary();
    }

    class HourlyEmployee : Employee
    {
        public double Hours { get; set; }
        public double HourRate { get; set; }

        public HourlyEmployee(
            string name,
            double hours,
            double hourRate)
            : base(name)
        {
            Hours = hours;
            HourRate = hourRate;
        }

        public override double CalculateSalary()
        {
            return Hours * HourRate;
        }
    }

    class SalariedEmployee : Employee
    {
        public double MonthlySalary { get; set; }

        public SalariedEmployee(
            string name,
            double monthlySalary)
            : base(name)
        {
            MonthlySalary = monthlySalary;
        }

        public override double CalculateSalary()
        {
            return MonthlySalary;
        }
    }

    class CommissionEmployee : Employee
    {
        public double Sales { get; set; }
        public double CommissionRate { get; set; }

        public CommissionEmployee(
            string name,
            double sales,
            double commissionRate)
            : base(name)
        {
            Sales = sales;
            CommissionRate = commissionRate;
        }

        public override double CalculateSalary()
        {
            return Sales * CommissionRate / 100;
        }
    }

    class Program
    {
        static void Main()
        {
            Employee[] employees =
            {
                new HourlyEmployee("Иван", 160, 800),
                new SalariedEmployee("Анна", 120000),
                new CommissionEmployee("Олег", 500000, 7)
            };

            foreach (Employee employee in employees)
            {
                Console.WriteLine($"{employee.Name}: зарплата {employee.CalculateSalary():F2}");
            }
        }
    }
}