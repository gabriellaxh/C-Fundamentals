using System;

public abstract class Tyre
{
    public string Name { get;  set; }
    public double Hardness { get;  set; }
    private double degradation = 100;

    protected Tyre(double hardness)
    {
        this.Hardness = hardness;
        this.degradation -= this.Hardness;
    }

    public virtual double Degradation
    {
        get => this.degradation;
        protected set
        {
            if (value < 0)
            {
                throw new ArgumentException("Blown Tyre");
            }
            this.degradation = value;
        }
    }
}
