using System;

public class Member
{
    private string name { get; set; }
    private DateTime dateOfBirth { get; set; }

    public string Name
    {
        get => this.name;
        set => this.name = value;
    }

    public DateTime DateOfBirth
    {
        get => this.dateOfBirth;
        set => this.dateOfBirth = value;
    }

    public Member()
    {

    }

    public Member(string name)
        :this()
    {
        this.name = name;
    }

    public Member(DateTime dateOfBirth)
        :this()
    {
        this.dateOfBirth = dateOfBirth;
    }

    public Member(string name,DateTime dateOfBirth)
        :this()
    {
        this.name = name;
        this.dateOfBirth = dateOfBirth;
    }
}
