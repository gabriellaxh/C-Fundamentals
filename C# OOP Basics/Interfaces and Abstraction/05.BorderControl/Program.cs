using System;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        List<string> information = new List<string>();
        var command = Console.ReadLine();
        while(command != "End")
        {
            information.Add(command);
            command = Console.ReadLine();
        }
        var endOfId = Console.ReadLine();
        foreach (var line in information)
        {
            if (line.EndsWith(endOfId))
            {
                var spl = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                Console.WriteLine(spl[spl.Length-1]);
            }
        }
    }
}
