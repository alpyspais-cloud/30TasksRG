using System;

namespace Task03
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
    }

    class Student : Person
    {
        public string Specialty { get; set; }
        public int Course { get; set; }

        public Student(
            string name,
            int age,
            string specialty,
            int course)
            : base(name, age)
        {
            Specialty = specialty;
            Course = course;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Имя: {Name}");
            Console.WriteLine($"Возраст: {Age}");
            Console.WriteLine($"Специальность: {Specialty}");
            Console.WriteLine($"Курс: {Course}");
        }
    }

    class Program
    {
        static void Main()
        {
            Student student = new Student("Анна", 19, "Программирование", 2);
            student.ShowInfo();
        }
    }
}