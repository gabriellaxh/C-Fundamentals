
public class Car
{
    private string carModel { get; set; }
    private string carSpeed { get; set; }

    public string CarModel
    {
        get => this.carModel;
        set => this.carModel = value;
    }

    public string CarSpeed
    {
        get => this.carSpeed;
        set => this.carSpeed = value;
    }

    public Car()
    {
        this.carModel = "";
        this.carSpeed = "";
    }

    public Car(string carModel, string carSpeed)
        : this()
    {
        this.carModel = carModel;
        this.carSpeed = carSpeed;
    }
}

