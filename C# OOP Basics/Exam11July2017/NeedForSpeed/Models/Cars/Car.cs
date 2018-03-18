using System.Text;

public abstract class Car
{
    private string brand { get; set; }
    private string model { get; set; }
    private int yearOfProduction { get; set; }
    private int horsePower { get; set; }
    private int acceleration { get; set; }
    private int suspension { get; set; }
    private int durability { get; set; }

    protected Car(string brand, string model, int yearOfProduction, int horsePower, int acceleration, int suspension, int durability)
    {
        this.Brand = brand;
        this.Model = model;
        this.YearOfProduction = yearOfProduction;
        this.HorsePower = horsePower;
        this.Acceleration = acceleration;
        this.Suspension = suspension;
        this.Durability = durability;
    }

    public string Brand
    {
        get => this.brand;
        set => this.brand = value;
    }

    public string Model
    {
        get => this.model;
        set => this.model = value;
    }

    public int YearOfProduction
    {
        get => this.yearOfProduction;
        set => this.yearOfProduction = value;
    }

    public int HorsePower
    {
        get => this.horsePower;
        set => this.horsePower = value;
    }

    public int Acceleration
    {
        get => this.acceleration;
        set => this.acceleration = value;
    }

    public int Suspension
    {
        get => this.suspension;
        set => this.suspension = value;
    }

    public int Durability
    {
        get => this.durability;
        set => this.durability = value;
    }

    public int GetOverallPerformance()
    {
        return (this.HorsePower / this.Acceleration) + (this.Suspension + this.Durability);
    }

    public int GetEnginePerformance()
    {
        return (this.HorsePower / this.Acceleration);
    }

    public int GetSuspensionPerformance()
    {
        return (this.Suspension + this.Durability);
    }

   public override string ToString()
    {
        var strB = new StringBuilder();
        strB.AppendLine($"{this.Brand} {this.Model} {this.YearOfProduction}")
            .AppendLine($"{this.HorsePower} HP, 100 m/h in {this.Acceleration} s")
            .AppendLine($"{this.Suspension} Suspension force, {this.Durability} Durability");

        return strB.ToString();
    }
}

