using System;
using System.Collections.Generic;
using System.Text;

public class Car
{
    private string model;
    private Engine engine;
    private string weight;
    private string color;

    public string Model
    {
        get => this.model;
        set => this.model = value;
    }

    public Engine Engine
    {
        get => this.engine;
        set => this.engine = value;
    }

    public string Weight
    {
        get => this.weight;
        set => this.weight = value;
    }

    public string Color
    {
        get => this.color;
        set => this.color = value;
    }

    public Car()
    {
        this.weight = "n/a";
        this.color = "n/a";
    }

    public Car(string model,Engine engine)
        :this()
    {
        this.model = model;
        this.engine = engine;
    }
    public Car(string model, Engine engine, string weight)
        :this(model,engine)
    {
        this.weight = weight;
    }
    public Car(string model, Engine engine, string weight, string color)
       : this(model, engine)
    {
        this.weight = weight;
        this.color = color;
    }
}

