using System;

public class Program
{
    static void Main(string[] args)
    {
        var carInfo = Console.ReadLine().Split();
        Car car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]), double.Parse(carInfo[3]));

        var truckInfo = Console.ReadLine().Split();
        Truck truck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]), double.Parse(truckInfo[3]));

        var busInfo = Console.ReadLine().Split();
        Bus bus = new Bus(double.Parse(busInfo[1]), double.Parse(busInfo[2]), double.Parse(busInfo[3]));

        var commandsCount = int.Parse(Console.ReadLine());
        for (int i = 0; i < commandsCount; i++)
        {
            var command = Console.ReadLine().Split();
            switch (command[0])
            {
                case "Drive":
                    switch (command[1])
                    {
                        case "Car":
                            car.Drive(double.Parse(command[2]));
                            break;
                        case "Truck":
                            truck.Drive(double.Parse(command[2]));
                            break;
                        case "Bus":
                            bus.Drive(double.Parse(command[2]));
                            break;
                    }
                    break;

                case "DriveEmpty":
                    bus.DriveEmpty(double.Parse(command[2]));
                    break;

                case "Refuel":
                    switch (command[1])
                    {
                        case "Car":
                            car.Refuel(double.Parse(command[2]));
                            break;
                        case "Truck":
                            truck.Refuel(double.Parse(command[2]));
                            break;
                        case "Bus":
                            bus.Refuel(double.Parse(command[2]));
                            break;
                    }
                    break;
            }
        }
        Console.WriteLine($"Car: {car.FuelQuantity:f2}");
        Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
        Console.WriteLine($"Bus: {bus.FuelQuantity:f2}");
    }
}

