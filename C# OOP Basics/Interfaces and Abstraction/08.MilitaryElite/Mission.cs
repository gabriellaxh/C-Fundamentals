using System;

public class Mission
{
    private string codeName;
    private string state = "inProgress";

    public Mission(string codeName, string state)
    {
        this.CodeName = codeName;
        this.State = state;
    }

    public string CodeName
    {
        get => this.codeName;
        set => this.codeName = value;
    }

    public string State
    {
        get => this.state;
        set
        {
            this.state = value;

        }
    }

    public void CompleteMission()
    {
        state = "Finished";
    }

    public override string ToString()
    {
        return $"Code Name: {codeName} State: {state}";
    }
}