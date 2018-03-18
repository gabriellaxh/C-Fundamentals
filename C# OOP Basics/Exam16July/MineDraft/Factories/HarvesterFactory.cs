using System;

public class HarvesterFactory
{
    public static Harvester CreateHarvester(string type,string id, double oreOutput, double energyRequirement,int sonicFactor)
    {
        switch (type)
        {
            case "Sonic":
                return new SonicHarvester(id, oreOutput, energyRequirement,sonicFactor);

            case "Hammer":
                return new HammerHarvester(id, oreOutput, energyRequirement);
        }

        throw new ArgumentException();
    }
}

