public class Child
{
    private string childName { get; set; }
    private string childBirthday { get; set; }

    public string ChildName
    {
        get => this.childName;
        set => this.childName = value;
    }

    public string ChildBirthday
    {
        get => this.childBirthday;
        set => this.childBirthday = value;
    }

    public Child()
    {

    }

    public Child(string childName, string childBirthday)
        :this()
    {
        this.childName = childName;
        this.childBirthday = childBirthday;
    }
}

