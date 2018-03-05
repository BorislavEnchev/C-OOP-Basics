using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class Person
{
    string name;
    int age;
    
    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public int Age
    {
        get { return this.age; }
        set { this.age = value; }
    }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public override string ToString()
    {
        return $"{this.Name}, {this.age}";
    }
}

