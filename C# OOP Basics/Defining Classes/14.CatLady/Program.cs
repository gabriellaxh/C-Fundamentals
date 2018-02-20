using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        var command = Console.ReadLine();
        var cats = new List<Cat>();

        while (command != "End")
        {
            var info = command.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string name = info[1];
            string breed = info[0];

            switch (breed)
            {
                case "Siamese":
                    int earSize = int.Parse(info[2]);
                    var newSiam = new Siamese(name, breed, earSize);
                    cats.Add(newSiam);
                    break;

                case "Cymric":
                    double furLength = double.Parse(info[2]);
                    var newCymric = new Cymric(name, breed, furLength);
                    cats.Add(newCymric);
                    break;

                case "StreetExtraordinaire":
                    int decibelsOfMeows = int.Parse(info[2]);
                    var newStreetExtr = new StreetExtraordinaire(name, breed, decibelsOfMeows);
                    cats.Add(newStreetExtr);
                    break;
            }
            command = Console.ReadLine();
        }
        var catName = Console.ReadLine();
        var cat = cats.FirstOrDefault(x => x.Name == catName);
        Console.WriteLine(cat);
    }

}



