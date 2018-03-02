using System.Collections.Generic;
using System.Text;

public class Commando : SpecialisedSoldier, ICommando
{
    private List<Mission> missions;

    public Commando(int id, string firstName, string lastName, double salary,string corps, List<Mission> missions)
        :base(id, firstName, lastName, salary, corps)
    {
        this.Missions = missions;
    }

    public List<Mission> Missions
    {
        get => this.missions;
        set => this.missions = value;
    }

    public override string ToString()
    {
        var stringB = new StringBuilder();
        stringB.AppendLine(base.ToString());
        stringB.AppendLine("Missions:");
        foreach (var mission in missions)
        {
            stringB.AppendLine("  " + mission);
        }

        return stringB.ToString().Trim();
    }
}

