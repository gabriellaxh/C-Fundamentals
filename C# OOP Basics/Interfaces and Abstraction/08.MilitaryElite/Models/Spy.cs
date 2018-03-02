using System;
using System.Text;

public class Spy : Soldier, ISpy
{
    private int codeNumber;

    public Spy(int id, string firstName, string lastName, int codeNumber)
        : base(id, firstName, lastName)
    {
        this.CodeNumber = codeNumber;
    }

    public int CodeNumber
    {
        get => this.codeNumber;
        set => this.codeNumber = value;
    }

    public override string ToString()
    {
        var stringB = new StringBuilder();
        stringB.AppendLine(base.ToString());
        stringB.Append($"Code Number: {codeNumber}");
        return stringB.ToString();
    }
}

