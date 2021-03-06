﻿using System.Collections.Generic;
using System.Linq;
using System.Text;

public class CasualRace : Race
{
    public CasualRace(int length, string route, int prizePool)
        : base(length, route, prizePool)
    {

    }

    private List<Car> GetWinners()
    {
        var winners = this.Participants.Values
                                       .OrderByDescending(x => x.GetOverallPerformance())
                                       .Take(3)
                                       .ToList();
        return winners;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        var winners = GetWinners();
        int counter = 1;
        int moneyWon = 0;

        sb.AppendLine($"{this.Route} - {this.Length}");

        foreach (var winner in winners)
        {
            var performancePoints = winner.GetOverallPerformance();

            if (counter == 1)
                moneyWon = (this.PrizePool * 50 / 100);

            else if (counter == 2)
                moneyWon = (this.PrizePool * 30 / 100);

            else if (counter == 3)
                moneyWon = (this.PrizePool * 20 / 100);

            sb.AppendLine($"{counter}. {winner.Brand} {winner.Model} {performancePoints}PP - ${moneyWon}");
            counter++;
        }

        return sb.ToString();
    }
}

