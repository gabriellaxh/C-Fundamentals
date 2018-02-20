using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        var olderThanThirty = new Dictionary<string,int>();
        for (int i = 0; i < n; i++)
        {
            var info = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if(int.Parse(info[1]) > 30)
            {
                olderThanThirty.Add(info[0],int.Parse(info[1]));
            }
        }
        foreach (var person in olderThanThirty.OrderBy(x => x.Key))
        {
            Console.WriteLine($"{person.Key} - {person.Value}");
        }
    }
}

