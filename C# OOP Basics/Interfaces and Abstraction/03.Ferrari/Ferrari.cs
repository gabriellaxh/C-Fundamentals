public class Ferrari : ICar
{
    private string model;
    private string driver;

    public Ferrari(string driver)
    {
        this.Model = model;
        this.driver = driver;
    }

    public string Model
    {
        get => this.model;
        set => this.model = "488-Spider";
    }

    public string Driver
    {
        get => this.driver;
        set => this.driver = value;
    }

    public string Brakes()
    {
        return "Brakes!";
    }

    public string PushGas()
    {
        return "Zadu6avam sA!";
    }

    public override string ToString()
    {
        return $"{this.Model}/{Brakes()}/{PushGas()}/{this.driver}";
    }
}

