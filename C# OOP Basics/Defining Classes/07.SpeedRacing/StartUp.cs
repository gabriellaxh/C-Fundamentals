using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        int count = int.Parse(Console.ReadLine());

        var cars = new List<Car>();
        for (int i = 0; i < count; i++)
        {
            var info = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string car = info[0];
            double fuelAmount = double.Parse(info[1]);
            double fuelConsumption = double.Parse(info[2]);
            var newCar = new Car()
            {
                Model = car,
                FuelAmount = fuelAmount,
                FuelConsumption = fuelConsumption
            };
            cars.Add(newCar);
        }
        var line = Console.ReadLine();
        while (line != "End")
        {
            var l = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string model = l[1];
            double amountOfKm = double.Parse(l[2]);

            var carToDrive = cars.Where(x => x.Model == model).FirstOrDefault();
            carToDrive.Drive(amountOfKm);

            line = Console.ReadLine();
        }
        foreach (var car in cars)
        {
            Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.DistanceTraveled}");
        }
    }
}

