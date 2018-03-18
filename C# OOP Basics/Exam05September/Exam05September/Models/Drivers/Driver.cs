public abstract class Driver
{
    public string Name { get;  set; }
    public double TotalTime { get;  set; }
    public Car Car { get;  set; }
    public double FuelConsumptionPerKm { get;  set; }
    public double Speed { get;  set; }

    protected Driver(string name, Car car)
    {
        this.Name = name;
        this.TotalTime = 0;
        this.Car = car;
        this.Speed = (this.Car.Hp + this.Car.Tyre.Degradation) / this.Car.FuelAmount;
    }
 
}

