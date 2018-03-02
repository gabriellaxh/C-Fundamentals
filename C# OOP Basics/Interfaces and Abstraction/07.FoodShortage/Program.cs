using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());
        var people = new List<IBuyer>();
        for (int i = 0; i < num; i++)
        {
            var info = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if(info.Length == 4)
            {
                var citizen = new Citizen()
                {
                    Name = info[0],
                    age = int.Parse(info[1]),
                    id = info[2],
                    birthdate = info[3]
                };
                people.Add(citizen);
            }
            else
            {
                var rebel = new Rebel()
                {
                    Name = info[0],
                    age = int.Parse(info[1]),
                    group = info[2],
                };
                people.Add(rebel);
            }
        }
        var name = Console.ReadLine();
        while(name != "End")
        {
           var person = people.FirstOrDefault(x => x.Name == name);
            if (person != null)
            {
               person.BuyFood();
            }
            name = Console.ReadLine();
        }
        var result = people.Sum(x => x.Food);
        Console.WriteLine(result);
    }
}

