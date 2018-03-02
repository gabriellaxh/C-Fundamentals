public class Citizen : IPerson
{
    private string name;
    private int age;

    public Citizen(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public string Name
    {
        get => this.name;
        set => this.name = value;
    }

    public int Age
    {
        get => this.age;
        set => this.age = value;
    }
}

