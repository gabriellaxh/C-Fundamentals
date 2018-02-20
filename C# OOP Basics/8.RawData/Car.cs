using System;
using System.Collections.Generic;
using System.Text;

public class Car
{
    private string model;
    private Engine engine;
    private Cargo cargo;
    private List<Tire> tires;

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

    public Cargo Cargo
    {
        get => this.cargo;
        set => this.cargo = value;
    }

    public List<Tire> Tires
    {
        get => this.tires;
        set => this.tires = value;
    }

    public Car()
    {

    }

    public Car(string model, Engine engine,Cargo cargo,List<Tire> tires)
        :this()
    {
        this.model = model;
        this.engine = engine;
        this.cargo = cargo;
        this.tires = tires;
    }
}

