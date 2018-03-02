public class Car : Vehicle
{
    private double fuelQuantity;
    private double fuelConsumptionPerKm;

    public Car(double fuelQuantity, double fuelConsumptionPerKm, double airConditionerConsumption)
        :base(fuelQuantity,fuelConsumptionPerKm,airConditionerConsumption)
    {
       
    }
}

