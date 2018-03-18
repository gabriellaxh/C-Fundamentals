using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class DraftManager
{
    private Dictionary<string, Harvester> harvesters;
    private Dictionary<string, Provider> providers;
    private string mode;
    private double totalStoredEnergy;
    private double totalMinedOre;

    public DraftManager()
    {
        this.mode = "Full";
        this.totalMinedOre = 0;
        this.totalStoredEnergy = 0;
        this.harvesters = new Dictionary<string, Harvester>();
        this.providers = new Dictionary<string, Provider>();

    }
    public string RegisterHarvester(List<string> arguments)
    {
        var type = arguments[0];
        string id = arguments[1];
        double oreOutput = double.Parse(arguments[2]);
        double energyRequirement = double.Parse(arguments[3]);
        int sonicFactor = 0;

        if (type == "Sonic")
            sonicFactor = int.Parse(arguments[4]);
        try
        {
            var harvester = HarvesterFactory.CreateHarvester(type, id, oreOutput, energyRequirement, sonicFactor);
            harvesters.Add(id, harvester);
        }
        catch (Exception ex)
        {
            return ex.Message;
        }

        return $"Successfully registered {type} Harvester - {id}";
    }

    public string RegisterProvider(List<string> arguments)
    {
        string type = arguments[0];
        string id = arguments[1];
        double energyOutput = double.Parse(arguments[2]);

        try
        {
            var provider = ProviderFactory.CreateProvider(type, id, energyOutput);
            providers.Add(id, provider);
        }
        catch (Exception ex)
        {
            return ex.Message;
        }

        return $"Successfully registered {type} Provider - {id}";
    }

    public string Day()
    {
        var minedOrePerDaty = 0.0;
        var providedEnergy = providers.Values.Sum(x => x.EnergyOutput);
        var requiredEnergy = harvesters.Values.Sum(x => x.EnergyRequirement);
        totalStoredEnergy += providedEnergy;


        if (totalStoredEnergy >= requiredEnergy)
        {
            if (mode == "Full")
            {
                minedOrePerDaty += this.harvesters.Values.Sum(x => x.OreOutput);
                totalStoredEnergy -= requiredEnergy;
            }
            else if (mode == "Half")
            {
                minedOrePerDaty += this.harvesters.Values.Sum(x => x.OreOutput * 0.5);
                totalStoredEnergy -= requiredEnergy * 0.6;
            }
            totalMinedOre += minedOrePerDaty;
        }

        var sb = new StringBuilder();
        sb.AppendLine("A day has passed.")
          .AppendLine($"Energy Provided: {providedEnergy}")
          .AppendLine($"Plumbus Ore Mined: {minedOrePerDaty}");

        return sb.ToString().Trim();

    }

    public string Mode(List<string> arguments)
    {
        this.mode = arguments[0];

        return $"Successfully changed working mode to {mode} Mode";
    }

    public string Check(List<string> arguments)
    {
        var id = arguments[0];
        if (harvesters.ContainsKey(id))
        {
            var harvester = harvesters.FirstOrDefault(x => x.Key == id).Value;
            return harvester.ToString();
        }

        else if (providers.ContainsKey(id))
        {
            var provider = providers.FirstOrDefault(x => x.Key == id).Value;
            return provider.ToString();
        }

        return $"No element found with id - {id}";
    }

    public string ShutDown()
    {
        var sb = new StringBuilder();

        sb.AppendLine("System Shutdown")
            .AppendLine($"Total Energy Stored: {totalStoredEnergy}")
            .AppendLine($"Total Mined Plumbus Ore: {totalMinedOre}");

        return sb.ToString().Trim();
    }
}

