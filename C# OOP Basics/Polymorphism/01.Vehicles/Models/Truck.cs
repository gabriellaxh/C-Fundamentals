public class Truck : Vehicle
{
    public Truck(double fuelQuantity, double fuelConsumptionPerKm, double airConditionerConsump)
             : base(fuelQuantity, fuelConsumptionPerKm, airConditionerConsump)
    {

    }

    public override void Refuel(double fuel)
    {
        fuel *= 0.95;
        base.Refuel(fuel);
    }
}

