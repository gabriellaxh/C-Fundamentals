using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        var cars = new List<Car>();

        for (int i = 0; i < n; i++)
        {
            var info = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string model = info[0];
            int engineSpeed = int.Parse(info[1]);
            int enginePower = int.Parse(info[2]);
            int cargoWeight = int.Parse(info[3]);
            string cargoType = info[4];
            double tire1pr = double.Parse(info[5]);
            int tire1age = int.Parse(info[6]);
            double tire2pr = double.Parse(info[7]);
            int tire2age = int.Parse(info[8]);
            double tire3pr = double.Parse(info[9]);
            int tire3age = int.Parse(info[10]);
            double tire4pr = double.Parse(info[11]);
            int tire4age = int.Parse(info[12]);

            var tire1 = new Tire()
            {
                Pressure = tire1pr,
                Age = tire1age
            };
            var tire2 = new Tire()
            {
                Pressure = tire2pr,
                Age = tire2age
            };
            var tire3 = new Tire()
            {
                Pressure = tire3pr,
                Age = tire3age
            };
            var tire4 = new Tire()
            {
                Pressure = tire4pr,
                Age = tire4age
            };

            var tires = new List<Tire>()
            {
                tire1,
                tire2,
                tire3,
                tire4
            };

            var newCar = new Car()
            {
                Model = model,
                Engine = new Engine()
                {
                    EngineSpeed = engineSpeed,
                    EnginePower = enginePower
                },
                Cargo = new Cargo()
                {
                    CargoWeight = cargoWeight,
                    CargoType = cargoType
                },
                Tires = tires
            };
            cars.Add(newCar);
        }
        string command = Console.ReadLine();
        if (command == "fragile")
        {
            var fragileCars = cars.Where(x => x.Cargo.CargoType == "fragile" && x.Tires.Any(t => t.Pressure < 1)).ToList();
            foreach (var car in fragileCars)
            {
                Console.WriteLine($"{car.Model}");
            }
            return;
        }
        else if (command == "flamable")
        {
            var flammableCars = cars.Where(x => x.Cargo.CargoType == "flamable" && x.Engine.EnginePower > 250).ToList();

            foreach (var car in flammableCars)
            {
                Console.WriteLine($"{car.Model}");
            }
            return;
        }
    }
}

