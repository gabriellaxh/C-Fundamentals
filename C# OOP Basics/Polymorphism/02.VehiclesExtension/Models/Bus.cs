public class Bus : Vehicle
{
    public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity)
       : base(fuelQuantity, fuelConsumption, tankCapacity)
    {

    }

    public void Drive(double kilometers)
    {
        if ((base.FuelQuantity - (base.FuelConsumption + 1.4) * kilometers) >= 0)
        {
            base.FuelQuantity -= (base.FuelConsumption + 1.4) * kilometers;
            System.Console.WriteLine($"Bus travelled {kilometers} km");
        }
        else
        {
            System.Console.WriteLine($"Bus needs refueling");
        }
    }

    public void DriveEmpty(double kilometers)
    {
        if ((base.FuelQuantity - (base.FuelConsumption) * kilometers) >= 0)
        {
            base.FuelQuantity -= (base.FuelConsumption) * kilometers;
            System.Console.WriteLine($"Bus travelled {kilometers} km");
        }
        else
        {
            System.Console.WriteLine($"Bus needs refueling");
        }
    }

    public void Refuel(double fuel)
    {
        if (fuel + base.FuelQuantity > TankCapacity)
            System.Console.WriteLine($"Cannot fit {fuel} fuel in the tank");

        else if (fuel <= 0)
            System.Console.WriteLine("Fuel must be a positive number");

        else
            base.FuelQuantity += fuel;
    }
}

