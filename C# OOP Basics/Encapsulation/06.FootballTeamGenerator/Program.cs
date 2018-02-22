using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        var command = Console.ReadLine();
        var teams = new List<Team>();


        while (command != "END")
        {
            var info = command.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            if (string.IsNullOrWhiteSpace(info[1]))
            {
                throw new ArgumentException("A name should not be empty.");
            }
            try
            {
                switch (info[0])
                {
                    case "Team":
                        var newTeam = new Team(info[1]);
                        teams.Add(newTeam);
                        break;

                    case "Add":
                        var team = teams.Where(x => x.Name == info[1]).FirstOrDefault();
                        if (team == null)
                        {
                            throw new ArgumentException($"Team {team} does not exist.");
                        }
                        else
                        {
                            string name = info[2];
                            int endurance = int.Parse(info[3]);
                            int sprint = int.Parse(info[4]);
                            int dribble = int.Parse(info[5]);
                            int passing = int.Parse(info[6]);
                            int shooting = int.Parse(info[7]);

                            var newPlayer = new Player(name, endurance, sprint, dribble, passing, shooting);
                            team.AddPlayer(newPlayer);
                        }
                        break;

                    case "Remove":
                        var team_ = teams.Where(x => x.Name == info[1]).FirstOrDefault();
                        bool playerCheck = teams.Find(x => x.Name == team_.Name).Players.Any(p => p.Name == info[2]);
                        if (!playerCheck)
                        {
                            throw new ArgumentException($"Player {info[2]} is not in {team_.Name} team.");
                        }

                        var player = team_.Players.FirstOrDefault(x => x.Name == info[2]);
                        team_.RemovePlayer(player);
                        break;

                    case "Rating":
                        var teamCheck = teams.Where(x => x.Name == info[1]).FirstOrDefault();
                        if (teamCheck == null)
                        {
                            throw new ArgumentException($"Team {info[1]} does not exist.");
                        }
                        else
                        {
                            double rating = teamCheck.CalculateRating();
                            Console.WriteLine($"{teamCheck.Name} - {Math.Round(rating)}");
                        }
                        break;
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            command = Console.ReadLine();
        }


    }
}
