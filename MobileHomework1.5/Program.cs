using MobileHomework1._5.Models;
using System;
using System.Collections.Generic;

namespace MobileHomework1._5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> personList = new List<Person>();

            var personType = 0;

            while(true)//loop indefinitely
            {
                Console.WriteLine("Please enter a (1)Student (2)Teacher (3)End");
                personType = Convert.ToInt32(Console.ReadLine());
                if(personType == 1)
                {
                    Student s = new Student();

                    Console.WriteLine("Enter Student Name");
                    s.Name = Console.ReadLine();
                    Console.WriteLine("Enter Student Age");
                    s.Age = Convert.ToInt32(Console.ReadLine());
                    personList.Add(s);
                    s.ID = Guid.NewGuid();
                }
                else if(personType == 2)
                {
                    Teacher t = new Teacher();
                    Console.WriteLine("Enter Teacher Name");
                    t.Name = Console.ReadLine();
                    personList.Add(t);
                }
                else if(personType >= 3)
                {
                    foreach(var p in personList)
                    {
                        Console.WriteLine("Student:");
                        Console.WriteLine($"Name: {p.Name}");
                        Console.WriteLine($"Age: {p.Age}");
                    }
                    break;
                }
            }

        }
    }
}
