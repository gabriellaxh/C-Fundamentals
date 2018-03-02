using System.Text;

public class Private : Soldier,IPrivate
{
    private double salary;
    
    public Private(int id,string firstName,string lastName,double salary)
        :base(id, firstName,lastName)
    {
        this.Salary = salary;
    }
    public double Salary
    {
        get => this.salary;
        set => this.salary = value;
    }

    public override string ToString()
    {
        var stringb = new StringBuilder();
        stringb.Append(base.ToString());
        stringb.Append($"Salary: {salary:f2}");

        return stringb.ToString();
    }
}

