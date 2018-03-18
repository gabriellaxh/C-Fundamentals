using System;
using System.Text;

public abstract class Harvester : Miner
{
    private double oreOutput;
    private double energyRequirement;

    protected Harvester(string id, double oreOutput, double energyRequirement)
        :base(id)
    {
        this.OreOutput = oreOutput;
        this.EnergyRequirement = energyRequirement;
    }

    public double OreOutput
    {
        get => this.oreOutput;
        protected set
        {
            if (value >= 0)
                this.oreOutput = value;
            else
                throw new ArgumentException($"Harvester is not registered, because of it's OreOutput");
        }
    }

    public double EnergyRequirement
    {
        get => this.energyRequirement;
        protected set
        {
            if (value >= 0 && value <= 20000)
                this.energyRequirement = value;
            else
                throw new ArgumentException($"Provider is not registered, because of it's EnergyRequirement");
        }
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        var type = this.GetType().Name.Replace("Harvester","");

        sb.AppendLine($"{type} Harvester - {this.Id}")
            .AppendLine($"Ore Output: {this.OreOutput}")
            .AppendLine($"Energy Requirement: {this.EnergyRequirement}");

        return sb.ToString().Trim();
    }
}

