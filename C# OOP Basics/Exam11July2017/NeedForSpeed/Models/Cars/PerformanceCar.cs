using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class PerformanceCar : Car
{
    private List<string> addOns { get; set; }

    public PerformanceCar(string brand, string model, int yearOfProduction, int horsePower, int acceleration, int suspension, int durability)
        : base(brand, model, yearOfProduction, horsePower, acceleration, suspension, durability)
    {
        base.HorsePower += horsePower * 50 / 100;
        base.Suspension -= suspension * 25 / 100;
        this.AddOns = new List<string>();
    }


    public List<string> AddOns
    {
        get => this.addOns;
         set => this.addOns = value;
    }

    public override string ToString()
    {
        var sb = base.ToString();

        if (this.AddOns.Any())
            sb += $"Add-ons: {string.Join(", ", this.AddOns)}";

        else
            sb += $"Add-ons: None";


        return sb;
    }
}

