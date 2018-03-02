public class Rebel : IBuyer
{
    private string name;
    public int age;
    public string group;
    public int food;

    public Rebel()
    {

    }
    public Rebel(string name, int age, string group)
    {
        this.Name = name;
        this.age = age;
        this.group = group;
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
        return this.food += 5;
    }
}

