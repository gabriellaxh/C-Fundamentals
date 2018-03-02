public class Citizen : IBuyer
{
    public string name;
    public int age;
    public string id;
    public string birthdate;
    public int food;

    public Citizen()
    {

    }
    public Citizen(string name, int age, string id, string birthdate)
    {
        this.name = name;
        this.age = age;
        this.id = id;
        this.birthdate = birthdate;
    }

    public string Name
    {
        get => this.name;
        set => this.name = value;
    }

    public int Food
    {
        get => this.food;
        set => this.food = value;
    }

    public int BuyFood()
    {
        return this.food += 10;
    }
}

