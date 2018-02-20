public class Engine
{
    private string model { get; set; }
    private int power { get; set; }
    private string displacement { get; set; }
    private string efficiency { get; set; }

    public string Model
    {
        get => this.model;
        set => this.model = value;
    }

    public int Power
    {
        get => this.power;
        set => this.power = value;
    }

    public string Displacement
    {
        get => this.displacement;
        set => this.displacement = value;
    }

    public string Efficiency
    {
        get => this.efficiency;
        set => this.efficiency = value;
    }

    public Engine()
    {
        this.displacement = "n/a";
        this.efficiency = "n/a";

    }
    public Engine(string model,int power)
        :this()
    {
        this.model = model;
        this.power = power;
    }
    public Engine(string model, int power, string displacement)
        :this(model,power)
    {
        this.displacement = displacement;
    }
    public Engine(string model, int power, string displacement, string efficiency)
        :this(model,power)
    {
        this.displacement = displacement;
        this.efficiency = efficiency;
    }
}