public class Cat
{
    private string name { get; set; }
    private string breed { get; set; }

    public string Name
    {
        get => this.name;
        set => this.name = value;
    }

    public string Breed
    {
        get => this.breed;
        set => this.breed = value;
    }

    public Cat()
    {

    }

    public Cat(string name,string breed)
        :this()
    {
        this.name = name;
        this.breed = breed;
    }

    public override string ToString()
    {
        return $"{this.breed} {this.name}";
    }
}
