using System;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        var commands = Console.ReadLine();
        var animals = new List<Animal>();

        int counter = 0;
        while (commands != "End")
        {
            var info = commands.Split();
            if (counter % 2 == 0)
            {
                switch (info[0])
                {
                    case "Hen":
                        var hen = new Hen(info[1], double.Parse(info[2]), double.Parse(info[3]));
                        var henFood = Console.ReadLine().Split();
                        Console.WriteLine(hen.ProduceSound());
                        hen.Weight += double.Parse(henFood[1]) * 0.35;
                        hen.FoodEaten += int.Parse(henFood[1]);
                        animals.Add(hen);
                        break;

                    case "Owl":
                        var owl = new Owl(info[1], double.Parse(info[2]), double.Parse(info[3]));
                        var owlFood = Console.ReadLine().Split();
                        Console.WriteLine(owl.ProduceSound());
                        if (owlFood[0] == "Meat")
                        {
                            owl.Weight += double.Parse(owlFood[1]) * 0.25;
                            owl.FoodEaten += int.Parse(owlFood[1]);
                        }
                        else
                            Console.WriteLine($"Owl does not eat {owlFood[0]}!");
                        animals.Add(owl);
                        break;

                    case "Mouse":
                        var mouse = new Mouse(info[1], double.Parse(info[2]), info[3]);
                        var mouseFood = Console.ReadLine().Split();
                        Console.WriteLine(mouse.ProduceSound());
                        if (mouseFood[0] == "Vegetable" || mouseFood[0] == "Fruit")
                        {
                            mouse.Weight += double.Parse(mouseFood[1]) * 0.10;
                            mouse.FoodEaten += int.Parse(mouseFood[1]);
                        }
                        else
                            Console.WriteLine($"Mouse does not eat {mouseFood[0]}!");
                        animals.Add(mouse);
                        break;

                    case "Cat":
                        var cat = new Cat(info[1], double.Parse(info[2]), info[3], info[4]);
                        var catFood = Console.ReadLine().Split();
                        Console.WriteLine(cat.ProduceSound());
                        if (catFood[0] == "Vegetable" || catFood[0] == "Meat")
                        {
                            cat.Weight += double.Parse(catFood[1]) * 0.30;
                            cat.FoodEaten += int.Parse(catFood[1]);
                        }
                        else
                            Console.WriteLine($"Cat does not eat {catFood[0]}!");
                        animals.Add(cat);
                        break;

                    case "Dog":
                        var dog = new Dog(info[1], double.Parse(info[2]), info[3]);
                        var dogFood = Console.ReadLine().Split();
                        Console.WriteLine(dog.ProduceSound());
                        if (dogFood[0] == "Meat")
                        {
                            dog.Weight += double.Parse(dogFood[1]) * 0.40;
                            dog.FoodEaten += int.Parse(dogFood[1]);
                        }
                        else
                            Console.WriteLine($"Dog does not eat {dogFood[0]}!");
                        animals.Add(dog);
                        break;

                    case "Tiger":
                        var tiger = new Tiger(info[1], double.Parse(info[2]), info[3], info[4]);
                        var tigerFood = Console.ReadLine().Split();
                        Console.WriteLine(tiger.ProduceSound());
                        if (tigerFood[0] == "Meat")
                        {
                            tiger.Weight += double.Parse(tigerFood[1]) * 1.00;
                            tiger.FoodEaten += int.Parse(tigerFood[1]);
                        }
                        else
                            Console.WriteLine($"Tiger does not eat {tigerFood[0]}!");
                        animals.Add(tiger);
                        break;
                }
            }
            counter++;
            if (counter % 2 == 0)
                commands = Console.ReadLine();
        }

        foreach (var an in animals)
        {
            Console.WriteLine(an);
        }
    }
}

