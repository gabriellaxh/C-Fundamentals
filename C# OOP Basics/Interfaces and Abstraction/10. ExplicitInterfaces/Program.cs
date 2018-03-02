using System;
using System.Collections;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        var line = Console.ReadLine().Split();
        while(line[0] != "End")
        {
            string name = line[0];
            string country = line[1];
            int age = int.Parse(line[2]);

            var newCitizen = new Citizen(name, age, country);

            Console.WriteLine(((IPerson)newCitizen).GetName());
            Console.WriteLine(((IResident)newCitizen).GetName());

            line = Console.ReadLine().Split();
        }
        
    }
}

