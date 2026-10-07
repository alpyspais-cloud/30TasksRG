namespace Task04
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
    }

    class Manager : Employee
    {
        public int TeamSize { get; set; }

        public Manager(string name, double salary, int teamSize)
            : base(name, salary)
        {
            TeamSize = teamSize;
        }
    }

    class Developer : Employee
    {
        public string ProgrammingLanguage { get; set; }

        public Developer(
            string name,
            double salary,
            string programmingLanguage)
            : base(name, salary)
        {
            ProgrammingLanguage = programmingLanguage;
        }
    }

    class Program
    {
        static void Main()
        {
            Manager manager = new Manager("Иван", 90000, 5);
            Developer developer = new Developer("Мария", 85000, "C#");

            Console.WriteLine($"Менеджер: {manager.Name}, зарплата: {manager.Salary}, команда: {manager.TeamSize}");
            Console.WriteLine($"Разработчик: {developer.Name}, зарплата: {developer.Salary}, язык: {developer.ProgrammingLanguage}");
        }
    }
}