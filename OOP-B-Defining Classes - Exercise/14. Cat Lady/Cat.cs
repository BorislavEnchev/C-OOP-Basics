using System;
using System.Collections.Generic;
using System.Text;

public class Cat
{
    private string name;
    private string breed;
    private double characteristics;

    public Cat(string breed, string name, double characteristic)
    {
        this.breed = breed;
        this.name = name;
        this.characteristics = characteristic;
    }

    public string Name { get { return this.name; } }

    public override string ToString()
    {
        if (this.breed == "Cymric")
        {
            return $"{this.breed} {this.name} {this.characteristics:F2}";
        }
        else
        {
            return $"{this.breed} {this.name} {(int)this.characteristics}";
        }
    }

}


