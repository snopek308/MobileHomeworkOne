using MobileHomework1._5.Models;
using System;
using System.Collections.Generic;
using static MobileHomework1._5.Enums;

namespace MobileHomework1._5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Need to understand how this is possible??
            //List<Person> personList = new List<Person>();
            List<Student> studentList = new List<Student>();
            List<Teacher> teacherList = new List<Teacher>();
            var personType = 0;

            while(true)//loop indefinitely
            {
                Console.WriteLine("Please enter a (1)Student (2)Teacher (3)End");
                personType = Convert.ToInt32(Console.ReadLine());
                if(personType == 1)
                {
                    Student s = new Student();
                    s.ID = Guid.NewGuid();
                    Console.WriteLine("Enter Student Name");
                    s.Name = Console.ReadLine();
                    Console.WriteLine("Enter Student Age");
                    s.Age = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Program (1)Computer Science, (2)Accounting, (3)Marketing, (4)Nursing");
                    var program = Console.ReadLine();
                    s.Program = (SchoolProgram)Enum.Parse(typeof(SchoolProgram), program);
                    Console.WriteLine("Credits Earned: ");
                    s.CreditsEarned = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Choose");
                    studentList.Add(s);

                }
                else if(personType == 2)
                {
                    Teacher t = new Teacher();
                    t.ID = Guid.NewGuid();
                    Console.WriteLine("Enter Teacher Name: ");
                    t.Name = Console.ReadLine();
                    Console.WriteLine("Enter Program (1)Computer Science, (2)Accounting, (3)Marketing, (4)Nursing");
                    var program = Console.ReadLine();
                    t.Program = (SchoolProgram)Enum.Parse(typeof(SchoolProgram), program);
                    Console.WriteLine("Enter Years of Service: ");
                    t.YearsOfService = Convert.ToInt32(Console.ReadLine());
                    teacherList.Add(t);
                }
                else if(personType >= 3)
                {
                    foreach(var s in studentList)
                    {
                        Console.WriteLine($"Name: {s.Name}");
                        Console.WriteLine($"Age: {s.Age}");
                        Console.WriteLine($"Program: {s.Program}");
                        Console.WriteLine($"Student ID: {s.ID}");
                        Console.WriteLine($"Credits Earned: {s.CreditsEarned}");
                    }

                    foreach (var t in teacherList)
                    {
                        Console.WriteLine($"Name: {t.Name}");
                        Console.WriteLine($"Program: {t.Program}");
                        Console.WriteLine($"Teacher ID: {t.ID}");
                        Console.WriteLine($"Years Service: {t.YearsOfService}");
                    }
                    break;
                }
            }

        }
    }
}
