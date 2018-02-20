using System;

public class Program
{
    static void Main(string[] args)
    {
        var date1 = Console.ReadLine();
        var date2 = Console.ReadLine();
        var newDateMod = new DateModifier();
        Console.WriteLine(newDateMod.GetTheDifference(date1, date2));
    }
}

