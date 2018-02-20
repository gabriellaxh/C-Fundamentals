public class Siamese : Cat
{
    private string name { get; set; }
    private int earSize { get; set; }

    public int EarSize
    {
        get => this.earSize;
        set => this.earSize = value;
    }

    public Siamese()
    {

    }

    public Siamese(string name,string breed, int earSize)
        :this()
    {
        this.Name = name;
        this.Breed = breed;
        this.earSize = earSize;
    }

    public override string ToString()
    {
        return $"{this.Breed} {this.Name} {this.earSize}";
    }
}

