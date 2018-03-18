using System.Collections.Generic;
using System.Linq;
using System.Text;

public class CircuitRace : Race
{
    private int laps;

    public CircuitRace(int length, string route, int prizePool, int laps)
        : base(length, route, prizePool)
    {
        this.Laps = laps;
    }

    public int Laps
    {
        get => this.laps;
        private set => this.laps = value;
    }

    public List<Car> GetWinners()
    {
        var winners = this.Participants.Values.OrderByDescending(x => x.GetOverallPerformance())
                                              .Take(4)
                                              .ToList();
        return winners;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        var winners = GetWinners();

        int moneyWon = 0;
        int counter = 1;

        for (int i = 0; i < this.Laps; i++)
        {
            foreach (var participant in this.Participants)
            {
                participant.Value.Durability -= this.Length * this.Length;
            }
        }
        sb.AppendLine($"{this.Route} - {this.Length * this.Laps}");
        foreach (var winner in winners)
        {
            var pp = winner.GetOverallPerformance();

            if (counter == 1)
                moneyWon = this.PrizePool * 40 / 100;

            else if (counter == 2)
                moneyWon = this.PrizePool * 30 / 100;

            else if (counter == 3)
                moneyWon = this.PrizePool * 20 / 100;

            else if (counter == 4)
                moneyWon = this.PrizePool * 10 / 100;


            sb.AppendLine($"{counter}. {winner.Brand} {winner.Model} {pp}PP - ${moneyWon}");
            counter++;
        }

        return sb.ToString().Trim();
        
    }
}

