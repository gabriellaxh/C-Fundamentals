using System.Collections.Generic;
using System.Text;

public abstract class Race
{
    private int length { get; set; }
    private string route { get; set; }
    private int prizePool { get; set; }
    private Dictionary<int,Car> participants { get; set; }

    protected Race(int length, string route, int prizePool)
    {
        this.Length = length;
        this.Route = route;
        this.PrizePool = prizePool;
        participants = new Dictionary<int, Car>();
    }


    public int Length
    {
        get => this.length;
        protected set => this.length = value;
    }

    public string Route
    {
        get => this.route;
        protected set => this.route = value;
    }

    public int PrizePool
    {
        get => this.prizePool;
        protected set => this.prizePool = value;
    }

    public Dictionary<int, Car> Participants
    {
        get => this.participants;
        set => this.participants = value;
    }
}

