using System.Collections.Generic;

public class Garage
{
    private Dictionary<int,Car> parkedCars { get; set; }

    public Garage()
    {
        this.ParkedCars = new Dictionary<int, Car>();
    }

    public Dictionary<int, Car> ParkedCars
    {
        get => this.parkedCars;
        private set => this.parkedCars = value;
    }
}

