
public class Parent
{
    private string parentName { get; set; }
    private string parentBirthday { get; set; }

    public string ParentName
    {
        get => this.parentName;
        set => this.parentName = value;
    }

    public string ParentBirthday
    {
        get => this.parentBirthday;
        set => this.parentBirthday = value;
    }

    public Parent()
    {

    }

    public Parent(string parentName, string parentBirthday)
        :this()
    {
        this.parentName = parentName;
        this.parentBirthday = parentBirthday;
    }
}


