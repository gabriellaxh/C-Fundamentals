using System;
using System.Collections.Generic;
using System.Text;


public class Car
{
    private string model;
    private double fuelAmount;
    private double fuelConsumption;
    private double distanceTraveled;


    public string Model
    {
        get => this.model;
        set => model = value;
    }

    public double FuelAmount
    {
        get => this.fuelAmount;
        set => fuelAmount = value;
    }

    public double FuelConsumption
    {
        get => this.fuelConsumption;
        set => this.fuelConsumption = value;
    }

    public double DistanceTraveled
    {
        get => this.distanceTraveled;
        set => this.distanceTraveled = value;
    }

    public Car()
    {
        this.distanceTraveled = 0;
    }

    public Car(string model, double fuelAmount, double fuelConsumption)
        : this()
    {
        this.model = model;
        this.fuelAmount = fuelAmount;
        this.fuelConsumption = fuelConsumption;

    }

    public void Drive(double amountOfKm)
    {
       if((fuelConsumption * amountOfKm) <= fuelAmount)
        {
            fuelAmount -= fuelConsumption * amountOfKm;
            distanceTraveled += amountOfKm;
        }
        else
        {
            Console.WriteLine("Insufficient fuel for the drive");
        }
    }
}



