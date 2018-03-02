using System;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        List<string> information = new List<string>();
        var command = Console.ReadLine();
        while (command != "End")
        {
            information.Add(command);
            command = Console.ReadLine();
        }
        var year = Console.ReadLine();

        foreach (var line in information)
        {
            var spl = line.Split(new[] { ' ' }, StringSplitOptions.None);

            var stringgg = spl[spl.Length - 1].Split(new[] { '/' }, StringSplitOptions.None);
            if(stringgg.Length >= 3)
            {
                if (stringgg[2] == year)
                    Console.WriteLine(spl[spl.Length - 1]);
            }
        }
    }
}


