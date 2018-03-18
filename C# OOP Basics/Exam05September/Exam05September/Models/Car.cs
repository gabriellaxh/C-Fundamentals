using System;

public class Car
{
    public int Hp { get;  set; }
    private double fuelAmount { get; set; }
    public Tyre Tyre { get;  set; }

    public Car(int hp, double fuelAmount, Tyre tyre)
    {
        this.Hp = hp;
        this.FuelAmount = fuelAmount;
        this.Tyre = tyre;
    }

    public double FuelAmount
    {
        get => this.fuelAmount;
        protected set
        {
            if (value <= 160)
                this.fuelAmount = value;

            else if (value > 160)
                this.fuelAmount = 160;

            else if (value < 0)
                throw new ArgumentException();
        }
    }
}
