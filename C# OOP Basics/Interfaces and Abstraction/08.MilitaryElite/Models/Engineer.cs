using System.Collections.Generic;
using System.Text;

public class Engineer : SpecialisedSoldier, IEngineer
{
    private List<Repair> repairs;

    public Engineer(int id, string firstName, string lastName, double salary, string corps,List<Repair> repairs)
        :base(id,firstName,lastName,salary,corps)
    {
        this.Repairs = repairs;
    }
    public List<Repair> Repairs
    {
        get => this.repairs;
        set => this.repairs = value;
    }

    public override string ToString()
    {
        var stringBuild = new StringBuilder();
        stringBuild.AppendLine(base.ToString());
        stringBuild.AppendLine("Repairs:");
        foreach (var repair in repairs)
        {
            stringBuild.AppendLine("  " + repair);
        }

        return stringBuild.ToString().Trim();
    }
}

