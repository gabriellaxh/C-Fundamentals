using System;
using System.Text;

public abstract class Provider : Miner
{
    private double energyOutput;

    protected Provider(string id, double energyOutput)
        : base(id)
    {
        this.EnergyOutput = energyOutput;
    }

    public double EnergyOutput
    {
        get => this.energyOutput;
       protected set
        {
            if (value >= 0 && value < 10000)
                this.energyOutput = value;
            else
                throw new ArgumentException("Provider is not registered, because of it's EnergyOutput");
        }
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        var type = this.GetType().Name.Replace("Provider","");

        sb.AppendLine($"{type} Provider - {this.Id}")
            .AppendLine($"Energy Output: {this.EnergyOutput}");

        return sb.ToString().Trim();

    }
}

