public class Truck : Vehicle
{
    public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity)
       : base(fuelQuantity, fuelConsumption, tankCapacity)
    {

    }

    public void Drive(double kilometers)
    {
        if ((base.FuelQuantity - (base.FuelConsumption + 1.6) * kilometers) >= 0)
        {
            base.FuelQuantity -= (base.FuelConsumption + 1.6) * kilometers;
            System.Console.WriteLine($"Truck travelled {kilometers} km");
        }
        else
        {
            System.Console.WriteLine($"Truck needs refueling");
        }
    }

    public void Refuel(double fuel)
    {
        if (fuel + base.FuelQuantity > TankCapacity)
            System.Console.WriteLine($"Cannot fit {fuel} fuel in the tank");

        else if (fuel <= 0)
            System.Console.WriteLine("Fuel must be a positive number");

        else
            base.FuelQuantity += fuel * 0.95;
    }
}

