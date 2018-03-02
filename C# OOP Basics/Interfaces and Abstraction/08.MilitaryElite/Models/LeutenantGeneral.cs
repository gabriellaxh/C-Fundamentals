using System.Collections.Generic;
using System.Text;

public class LeutenantGeneral : Private, ILeutenantGeneral
{
    private List<Private> privates;

    public LeutenantGeneral(int id, string firstName, string lastName, double salary, List<Private> privates)
        : base(id, firstName, lastName, salary)
    {
        this.Privates = privates;
    }

    public List<Private> Privates
    {
        get => this.privates;
        set => this.privates = value;
    }

    public override string ToString()
    {
        var stringB = new StringBuilder();
        stringB.AppendLine(base.ToString());
        stringB.AppendLine("Privates:");
        foreach (var priv in privates)
        {
            stringB.AppendLine("  " + priv.ToString());
        }
        return stringB.ToString().Trim();
    }
}

