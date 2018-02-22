
using System;
using System.Collections.Generic;
using System.Linq;

public class Team
{
    private string name;
    private int rating;
    private List<Player> players;

    public Team()
    {

    }
    public Team(string name)
    {
        this.Name = name;
        rating = 0;
        players = new List<Player>();
    }

    public string Name
    {
        get => this.name;
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("A name should not be empty.");
            }
            this.name = value;
        }
    }

    public int Rating
    {
        get => this.rating;
        set => this.rating = value;
    }

    public List<Player> Players
    {
        get => this.players;
        set => this.players = value;
    }

    public void AddPlayer(Player player)
    {
        players.Add(player);
    }
    public void RemovePlayer(Player player)
    {
        players.Remove(player);
    }
    public double CalculateRating()
    {
        return players.Sum(x => x.GetRating());
    }
}

