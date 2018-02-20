using System;
using System.Collections.Generic;
using System.Text;

public class Cargo
{
    private int cargoWeight { get; set; }
    private string cargoType { get; set; }
    
    public int CargoWeight
    {
        get => this.cargoWeight;
        set => this.cargoWeight = value;
    }

    public string CargoType
    {
        get => this.cargoType;
        set => this.cargoType = value;
    }

    public Cargo()
    {

    }

    public Cargo(int cargoWeight, string cargoType)
    {
        this.cargoWeight = cargoWeight;
        this.cargoType = cargoType;
    }
    
}

