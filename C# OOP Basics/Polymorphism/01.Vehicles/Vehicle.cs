public abstract class Vehicle
{
    private double fuelQuantity;
    private double fuelConsumption;
    private double airConditionConsumption;

    public Vehicle(double fuelQuantity, double fuelConsumption, double airConditionConsumption)
    {
        this.fuelQuantity = fuelQuantity;
        this.fuelConsumption = fuelConsumption;
        this.airConditionConsumption = airConditionConsumption;
    }

    public virtual void Drive(double kilometers)
    {
        if (kilometers * (fuelConsumption + airConditionConsumption) > fuelQuantity)
            System.Console.WriteLine($"{GetType().Name} needs refueling");

        else
        {
            fuelQuantity -= kilometers * (fuelConsumption + airConditionConsumption);
            System.Console.WriteLine($"{GetType().Name} travelled {kilometers} km");
        }

    }

    public virtual void Refuel(double fuel)
    {
        fuelQuantity += fuel;
    }

    public override string ToString()
    {
        return $"{GetType().Name}: {fuelQuantity:f2}";
    }
}

