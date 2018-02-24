using System;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        var mordor = new Mordor();
        var foods = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                      .Select(x => FoodFactory.GetFood(x)).ToList();

        mordor.Eat(foods);
        Console.WriteLine(mordor);
    }
}

