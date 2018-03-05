using System;
using System.Collections.Generic;
using System.Text;

public class Car
{
    string model;
    double fuelAmount;
    double fuelConsumptionFor1km;
    double distanceTravelled;

    public Car(string model, double fuelAmount, double fuelConsumptionFor1km)
    {
        this.model = model;
        this.fuelAmount = fuelAmount;
        this.fuelConsumptionFor1km = fuelConsumptionFor1km;
        distanceTravelled = 0.0;
    }

    public string Model
    {
        get { return this.model; }
    }

    public double FuelAmount
    {
        get { return this.fuelAmount; }
        set { this.fuelAmount = value; }
    }

    public double FuelConsumptionFor1km
    {
        get { return this.fuelConsumptionFor1km; }
    }

    public double DistanceTraveled
    {
        get { return this.distanceTravelled; }
        set { this.distanceTravelled = value; }
    }

    public void Drive(double distance)
    {
        var fuelToSpend = distance * this.fuelConsumptionFor1km;

        if (this.fuelAmount < fuelToSpend)
        {
            Console.WriteLine("Insufficient fuel for the drive");
            return;
        }
        fuelAmount -= fuelToSpend;
        distanceTravelled += distance;
    }
}

