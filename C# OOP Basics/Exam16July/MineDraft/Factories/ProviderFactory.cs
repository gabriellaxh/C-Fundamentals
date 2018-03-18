﻿using System;

public class ProviderFactory
{
    public static Provider CreateProvider(string type, string id, double energyOutput)
    {
        switch (type)
        {
            case "Solar":
                return new SolarProvider(id, energyOutput);

            case "Pressure":
                return new PressureProvider(id, energyOutput);
        }

        throw new ArgumentException();
    }
}

