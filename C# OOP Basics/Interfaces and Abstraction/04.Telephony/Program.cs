using System;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        var phones = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.None).ToList();
        var sites = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.None).ToList();

        var smartphone = new Smartphone(phones, sites);

    }
}

