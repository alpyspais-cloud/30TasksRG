using System;

namespace Task14
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
    }

    class GraduateStudent : Student
    {
        public string ThesisTopic { get; set; }
        public string Supervisor { get; set; }

        public GraduateStudent(
            string name,
            int age,
            string specialty,
            int course,
            string thesisTopic,
            string supervisor)
            : base(name, age, specialty, course)
        {
            ThesisTopic = thesisTopic;
            Supervisor = supervisor;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Имя: {Name}");
            Console.WriteLine($"Возраст: {Age}");
            Console.WriteLine($"Специальность: {Specialty}");
            Console.WriteLine($"Курс: {Course}");
            Console.WriteLine($"Тема диплома: {ThesisTopic}");
            Console.WriteLine($"Руководитель: {Supervisor}");
        }
    }

    class Program
    {
        static void Main()
        {
            GraduateStudent student = new GraduateStudent(
                "Анна",
                24,
                "Информатика",
                2,
                "Искусственный интеллект",
                "Иван Петров");

            student.ShowInfo();
        }
    }
}