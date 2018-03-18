using System;

public class UltrasoftTyre : Tyre
{
    private double degradation { get; set; }
    public double Grip { get; set; }

    public UltrasoftTyre(double hardness, double grip) 
        : base(hardness)
    {
        base.Name = "Ultrasoft";
        this.Grip = grip;
        this.Degradation -= this.Hardness + this.Grip;
    }

    public override double Degradation
    {
        get => this.degradation;
        protected set
        {
            if (value < 30)
            {
                throw new ArgumentException("Blown Tyre");
            }
            this.degradation = value;
        }
    }
}

