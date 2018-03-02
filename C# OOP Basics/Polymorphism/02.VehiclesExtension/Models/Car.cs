public class Car : Vehicle
{
    public Car(double fuelQuantity, double fuelConsumption, double tankCapacity)
        : base(fuelQuantity, fuelConsumption, tankCapacity)
    {

    }

    public void Drive(double kilometers)
    {
        if (base.FuelQuantity - (kilometers * (base.FuelConsumption + 0.9)) >= 0)
        {
            base.FuelQuantity -= kilometers * (base.FuelConsumption + 0.9);
            System.Console.WriteLine($"Car travelled {kilometers} km");
        }

        else
        {
            System.Console.WriteLine("Car needs refueling");
        }
    }

    public void Refuel(double fuel)
    {
        if (fuel + base.FuelQuantity > base.TankCapacity)
            System.Console.WriteLine($"Cannot fit {fuel} fuel in the tank");

        else if (fuel <= 0)
            System.Console.WriteLine("Fuel must be a positive number");

        else
            base.FuelQuantity += fuel;
    }
}

