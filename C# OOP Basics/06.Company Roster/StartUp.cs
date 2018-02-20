using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        var people = new List<Employee>();

        for (int i = 0; i < n; i++)
        {
            var info = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string name = info[0];
            decimal salary = decimal.Parse(info[1]);
            string position = info[2];
            string department = info[3];
            var newEmpl = new Employee()
            {
                Name = name,
                Salary = salary,
                Position = position,
                Department = department
            };

            if (info.Length == 6)
            {
                string email = info[4];
                int age = int.Parse(info[5]);
                newEmpl.Email = email;
                newEmpl.Age = age;
            }
            else if (info.Length == 5)
            {
                int age;
                int.TryParse(info[4], out age);
                if (age > 0)
                {
                    newEmpl.Age = age;
                }
                else
                {
                    string email = info[4];
                    newEmpl.Email = email;
                }
            }
            people.Add(newEmpl);
        }
        var sorted = people.GroupBy(x => x.Department)
                           .Select(x => new
                           {
                               Department = x.Key,
                               AverageSalary = x.Average(s => s.Salary),
                               Employees = x.OrderByDescending(s => s.Salary)
                           })
                           .OrderByDescending(x => x.AverageSalary)
                           .FirstOrDefault();
        Console.WriteLine($"Highest Average Salary: {sorted.Department}");
        foreach (var employee in sorted.Employees)
        {
            Console.WriteLine($"{employee.Name} {employee.Salary:f2} {employee.Email} {employee.Age}");
        }
    }
}
