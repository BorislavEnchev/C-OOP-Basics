using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Company_Roster
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());

            var departments = new List<Department>();

            for (int i = 0; i < count; i++)
            {
                var input = Console.ReadLine().Split();
                var depName = input[3];

                if (!departments.Any(d=>d.Name == depName))
                {
                    var dep = new Department(depName);
                    departments.Add(dep);
                }

                var department = departments.FirstOrDefault(d => d.Name == depName);
                var employee = ParseEmployee(input);
                department.AddEmployee(employee);
            }

            var highestAvgDep = departments.OrderByDescending(d => d.AverageSalary).First();

            Console.WriteLine($"Highest Average Salary: {highestAvgDep.Name}");
            foreach (var emp in highestAvgDep.Employees.OrderByDescending(e => e.Salary))
            {
                Console.WriteLine($"{emp.Name} {emp.Salary:f2} {emp.Email} {emp.Age}");
            }
        }

        static Employee ParseEmployee(string[] input)
        {
            var name = input[0];
            var salary = decimal.Parse(input[1]);
            var position = input[2];
            var age = -1;
            var email = "n/a";

            if (input.Length == 6)
            {
                email = input[4];
                age = int.Parse(input[5]);
            }
            else if (input.Length == 5)
            {
                bool isAge = int.TryParse(input[4], out age);
                if (!isAge)
                {
                    email = input[4];
                    age = -1;
                }
            }
            var employee = new Employee(name, salary, position, email, age);
            return employee;
        }
    }
}