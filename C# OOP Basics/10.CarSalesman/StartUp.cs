using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        var engines = new List<Engine>();
        var cars = new List<Car>();

        for (int i = 0; i < n; i++)
        {
            var info = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string model = info[0];
            int power = int.Parse(info[1]);

            var newEng = new Engine()
            {
                Model = model,
                Power = power
            };
            if (info.Length == 4)
            {
                newEng.Displacement = info[2];
                newEng.Efficiency = info[3];
            }
            else if (info.Length != 2)
            {
                int displacement;
                int.TryParse(info[2], out displacement);
                if (displacement != 0)
                {
                    newEng.Displacement = info[2];
                }
                else
                {
                    newEng.Efficiency = info[2];
                }
            }
            engines.Add(newEng);


            engines.Add(newEng);
        }
        int count = int.Parse(Console.ReadLine());
        for (int i = 0; i < count; i++)
        {
            var carInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string model = carInfo[0];
            Engine engine = engines.Where(x => x.Model == carInfo[1]).FirstOrDefault();
            var newCar = new Car()
            {
                Model = model,
                Engine = engine
            };
            if (carInfo.Length == 4)
            {
                newCar.Weight = carInfo[2];
                newCar.Color = carInfo[3];
            }
            else if (carInfo.Length != 2)
            {
                int weight;
                int.TryParse(carInfo[2], out weight);
                if (weight != 0)
                {
                    newCar.Weight = carInfo[2];
                }
                else
                {
                    newCar.Color = carInfo[2];
                }
            }
            cars.Add(newCar);
        }

        foreach (var car in cars)
        {
            var carEngine = engines.Where(x => x.Model == car.Engine.Model).FirstOrDefault();
            Console.WriteLine($"{car.Model}:");
            Console.WriteLine($"  {carEngine.Model}:");
            Console.WriteLine($"    Power: {carEngine.Power}");
            Console.WriteLine($"    Displacement: {carEngine.Displacement}");
            Console.WriteLine($"    Efficiency: {carEngine.Efficiency}");
            Console.WriteLine($"  Weight: {car.Weight}");
            Console.WriteLine($"  Color: {car.Color}");
        }
    }
}

