using System;
using System.Text;

public class SpecialisedSoldier : Private, ISpecialisedSoldier
{
    private string corps;

    public SpecialisedSoldier(int id, string firstName, string lastName, double salary, string corps)
        :base(id,firstName,lastName,salary)
    {
        this.Corps = corps;
    }

    public string Corps
    {
        get => this.corps;
        set
        {
            if (value != "Airforces" && value != "Marines")
            {
                throw new ArgumentException("Invalid!");
            }

            corps = value;
        }
    }

    public override string ToString()
    {
        var stringb = new StringBuilder();

        stringb.AppendLine(base.ToString());
        stringb.Append($"Corps: {corps}");

        return stringb.ToString().Trim();
    }
}

