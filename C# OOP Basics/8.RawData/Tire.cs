using System;
using System.Collections.Generic;
using System.Text;


public class Tire
{
    private double pressure;
    private int age;

    public double Pressure
    {
        get => this.pressure;
        set => this.pressure = value;
    }

    public int Age
    {
        get => this.age;
        set => this.age = value;
    }
}

