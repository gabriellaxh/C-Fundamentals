using System;

public class Program
{
    static void Main(string[] args)
    {
        double carAirConditionerConsump = 0.9;
        double truckAirConditionerConsump = 1.6;

        var car = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        var newCar = new Car(double.Parse(car[1]), double.Parse(car[2]), carAirConditionerConsump);

        var truck = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        var newTruck = new Truck(double.Parse(truck[1]), double.Parse(truck[2]), truckAirConditionerConsump);

        var num = int.Parse(Console.ReadLine());
        for (int i = 0; i < num; i++)
        {
            var command = Console.ReadLine().Split();
            if (command[0] == "Drive")
            {
                if (command[1] == "Car")
                {
                    newCar.Drive(double.Parse(command[2]));
                }
                else
                {
                    newTruck.Drive(double.Parse(command[2]));
                }
            }
            else
            {
                if (command[1] == "Car")
                {
                    newCar.Refuel(double.Parse(command[2]));
                }
                else
                {
                    newTruck.Refuel(double.Parse(command[2]));
                }
            }
        }

        Console.WriteLine(newCar);
        Console.WriteLine(newTruck);
    }
}

