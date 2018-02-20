public class Cymric : Cat
{
    private string name { get; set; }
    private double furLength { get; set; }
    
    public double FurLength
    {
        get => this.furLength;
        set => this.furLength = value;
    }

    public Cymric()
    {

    }

    public Cymric(string name,string breed, double furLength)
        :this()
    {
        this.Name = name;
        this.Breed = breed;
        this.FurLength = furLength;
    }

    public override string ToString()
    {
        return $"{this.Breed} {this.Name} {this.furLength:f2}";
    }
}

