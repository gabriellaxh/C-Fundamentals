public abstract class Vehicle
{
    private double fuelQuantity;
    private double fuelConsumption;
    private double tankCapacity;

    public Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
    {
       //mind the sequence, the tank capacity comes first because of the FuelQuantity setter
        TankCapacity = tankCapacity;
        FuelQuantity = fuelQuantity;
        FuelConsumption = fuelConsumption;
    }

    public double FuelQuantity
    {
        get => this.fuelQuantity;
        set
        {
            if (TankCapacity < value)
            {
                this.fuelQuantity = 0;
            }
            else
            {
                this.fuelQuantity = value;
            }
        }
    }

    public double FuelConsumption
    {
        get => this.fuelConsumption;
        set => this.fuelConsumption = value;
    }

    public double TankCapacity
    {
        get => this.tankCapacity;
        set => this.tankCapacity = value;
    }
}

