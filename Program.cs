using System;
using System.Collections;
using System.Collections.Generic;

namespace Phase1Section5._6
{
    class Program
    {
        static void Main(string[] args)
        {
            runApp();
        }


        static void runApp()
        {
            Subject math = new Subject("Mathematics", 4);
            Subject physics = new Subject("Physics", 3);

            Teacher mathTeacher = new Teacher("John Smith", "Mathematics");
            Teacher physicsTeacher = new Teacher("Alice Johnson", "Physics");

            Student student1 = new Student("James", 20);
            Student student2 = new Student("Emma", 19);
            Student student3 = new Student("Michael", 21);

            List<Student> mathClassStudents = new List<Student> { student1, student2 };
            List<Student> physicsClassStudents = new List<Student> { student2, student3 };

            CClass mathClass = new CClass("Math Class", math, mathTeacher, mathClassStudents);
            CClass physicsClass = new CClass("Physics Class", physics, physicsTeacher, physicsClassStudents);

            Console.WriteLine("Math Class Details:");
            Console.WriteLine($"Class Name: {mathClass.ClassName}");
            Console.WriteLine($"Subject: {mathClass.Subject.Name} (Credits: {mathClass.Subject.Credits})");
            Console.WriteLine($"Teacher: {mathClass.Teacher.Name} (Department: {mathClass.Teacher.Department})");
            Console.WriteLine("Students:");
            foreach (var student in mathClass.Students)
            {
                Console.WriteLine($"- {student.Name} (Age: {student.Age})");
            }

            Console.WriteLine("\nPhysics Class Details:");
            Console.WriteLine($"Class Name: {physicsClass.ClassName}");
            Console.WriteLine($"Subject: {physicsClass.Subject.Name} (Credits: {physicsClass.Subject.Credits})");
            Console.WriteLine($"Teacher: {physicsClass.Teacher.Name} (Department: {physicsClass.Teacher.Department})");
            Console.WriteLine("Students:");
            foreach (var student in physicsClass.Students)
            {
                Console.WriteLine($"- {student.Name} (Age: {student.Age})");
            }
        }
    }
}

