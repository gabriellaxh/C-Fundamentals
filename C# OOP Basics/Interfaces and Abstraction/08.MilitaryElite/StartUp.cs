using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    static void Main(string[] args)
    {
        var command = Console.ReadLine();
        var people = new List<Soldier>();

        while (command != "End")
        {
            var info = command.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            try
            {
                switch (info[0])
                {
                    case "Private":
                        people.Add(new Private(int.Parse(info[1]), info[2], info[3], double.Parse(info[4])));
                        break;

                    case "Commando":
                        var missions = GetMissions(info.Skip(6).ToList());
                        people.Add(new Commando(int.Parse(info[1]), info[2], info[3], double.Parse(info[4]), info[5], missions));
                        break;

                    case "LeutenantGeneral":
                        var privates = GetPrivates(info.Skip(5).ToList(), people);
                        people.Add(new LeutenantGeneral(int.Parse(info[1]), info[2], info[3], double.Parse(info[4]), privates));
                        break;

                    case "Engineer":
                        var repairs = GetRepairs(info.Skip(6).ToList());
                        people.Add(new Engineer(int.Parse(info[1]), info[2], info[3], double.Parse(info[4]), info[5], repairs));
                        break;

                    case "Spy":
                        people.Add(new Spy(int.Parse(info[1]), info[2], info[3], int.Parse(info[4])));
                        break;
                }
            }
            catch (ArgumentException e)
            {
            }
            command = Console.ReadLine();
        }
        foreach (var person in people)
        {
            Console.WriteLine(person);
        }
    }

    private static List<Repair> GetRepairs(List<string> repairs)
    {
        var repairsList = new List<Repair>();
        for (int i = 0; i < repairs.Count; i+=2)
        {
            repairsList.Add(new Repair(repairs[i], int.Parse(repairs[i+1])));
        }
        return repairsList;
    }

    private static List<Private> GetPrivates(List<string> privates, List<Soldier> people)
    {
        var privatesList = new List<Private>();

        foreach (var priv in privates)
        {
            var person = people.Find(x => x.Id == int.Parse(priv)) as Private;
            privatesList.Add(person);
        }
        return privatesList;
    }

    public static List<Mission> GetMissions(List<string> missions)
    {
        var missionList = new List<Mission>();

        for (int i = 0; i < missions.Count; i += 2)
        {
            if (missions[i + 1] != "inProgress" && missions[i + 1] != "Finished")
            {
                continue;
            }
            missionList.Add(new Mission(missions[i], missions[i + 1]));
        }
        return missionList;
    }
}
