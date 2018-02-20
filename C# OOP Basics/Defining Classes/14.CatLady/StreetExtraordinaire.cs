public class StreetExtraordinaire : Cat
{
    private string name { get; set; }
    private int decibelsOfMeows { get; set; }

    public int DecibelsOfMeows
    {
        get => this.decibelsOfMeows;
        set => this.decibelsOfMeows = value;
    }

    public StreetExtraordinaire()
    {

    }

    public StreetExtraordinaire(string name,string breed,int decibelsOfMeows)
        :this()
    {
        this.Name = name;
        this.Breed = breed;
        this.decibelsOfMeows = decibelsOfMeows;
    }

    public override string ToString()
    {
        return $"{this.Breed} {this.Name} {this.decibelsOfMeows}";
    }
}

