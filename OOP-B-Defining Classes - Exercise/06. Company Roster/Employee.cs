using System;
using System.Collections.Generic;
using System.Text;

public class Employee
{
    string name;
    decimal salary;
    string position;
    string email;
    int age;

    public Employee(string name, decimal salary, string position)
    {
        this.name = name;
        this.salary = salary;
        this.position = position;
    }

    public Employee(string name, decimal salary, string position, string email, int age)
        : this(name, salary, position)
    {
        this.email = email;
        this.age = age;
    }

    public string Name
    {
        get { return this.name; }
    }

    public decimal Salary
    {
        get { return this.salary; }
    }
    
    public string Email
    {
        get { return this.email; }
    }

    public int Age
    {
        get { return this.age; }
    }
}

