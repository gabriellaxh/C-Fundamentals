public class Soldier : ISoldier
{
    private int id { get; set; }
    private string firstName { get; set; }
    private string lastName { get; set; }

    public Soldier(int id,string firstName, string lastName)
    {
        this.Id = id;
        this.FirstName = firstName;
        this.LastName = lastName;
    }

    public int Id
    {
        get => this.id;
        set => this.id = value;
    }

    public string FirstName
    {
        get => this.firstName;
        set => this.firstName = value;
    }

    public string LastName
    {
        get => this.lastName;
        set => this.lastName = value;
    }
    public override string ToString()
    {
        return $"Name: {firstName} {lastName} Id: {id} ";
    }
}

