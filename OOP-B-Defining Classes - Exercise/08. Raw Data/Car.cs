﻿using System;
using System.Collections.Generic;
using System.Text;

class Car
{
    private string model;
    private Engine engine;
    private Cargo cargo;
    private Tire[] tires;

    public Car(string model, Engine engine, Cargo cargo, Tire[] tires)
    {
        this.model = model;
        this.engine = engine;
        this.cargo = cargo;
        this.tires = tires;
    }

    public string Model
    {
        get { return this.model; }
    }

    public Engine Engine
    {
        get { return this.engine; }
    }

    public Cargo Cargo
    {
        get { return this.cargo; }
    }

    public Tire[] Tires
    {
        get { return this.tires; }
    }
}

