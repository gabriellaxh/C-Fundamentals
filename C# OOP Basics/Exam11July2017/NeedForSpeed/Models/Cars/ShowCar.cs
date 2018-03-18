public class ShowCar : Car
{
    private int stars { get; set; }

    public ShowCar(string brand, string model, int yearOfProduction, int horsePower, int acceleration, int suspension, int durability) 
        : base(brand, model, yearOfProduction, horsePower, acceleration, suspension, durability)
    {
        this.Stars = 0;
    }

    public int Stars
    {
        get => this.stars;
         set => this.stars = value;
    }

    public override string ToString()
    {
        var sb = base.ToString();

        sb += $"{this.Stars} *";

        return sb;
    }
}

