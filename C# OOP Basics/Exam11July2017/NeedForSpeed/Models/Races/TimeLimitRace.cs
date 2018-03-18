using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class TimeLimitRace : Race
{
    private int goldTime;

    public TimeLimitRace(int length, string route, int prizePool, int goldTime)
        : base(length, route, prizePool)
    {
        this.GoldTime = goldTime;
    }

    public int GoldTime
    {
        get => this.goldTime;
        set => this.goldTime = value;
    }

    public int GetTimePerformance()
    {
        var car = this.Participants.FirstOrDefault().Value;
        return this.Length * (car.HorsePower / 100) * car.Acceleration;
    }

    public override string ToString()
    {
        var participant = this.Participants.FirstOrDefault().Value;
        string medal = string.Empty;
        int moneyWon = 0;

        if (this.GetTimePerformance() <= this.goldTime)
        {
            medal = "Gold";
            moneyWon = this.PrizePool;
        }

        else if (this.GetTimePerformance() <= this.goldTime + 15)
        {
            medal = "Silver";
            moneyWon = this.PrizePool * 50 / 100;
        }

        else if (this.GetTimePerformance() > this.goldTime + 15)
        {
            medal = "Bronze";
            moneyWon = this.PrizePool * 30 / 100;
        }

        var sb = new StringBuilder();
        sb.AppendLine($"{this.Route} - {this.Length}")
            .AppendLine($"{participant.Brand} {participant.Model} - {this.GetTimePerformance()} s.")
            .AppendLine($"{medal} Time, ${moneyWon}.");
        Console.WriteLine();



        return sb.ToString().TrimEnd();
    }

}

