using System.Collections.Generic;
using System.Linq;

public class CarManager
{
    public Dictionary<int, Car> cars = new Dictionary<int, Car>();
    public Dictionary<int, Race> races = new Dictionary<int, Race>();
    public Garage garage;

    public CarManager()
    {
        this.cars = new Dictionary<int, Car>();
        this.races = new Dictionary<int, Race>();
        this.garage = new Garage();
    }

    public void Register(int id, string type, string brand, string model, int yearOfProduction, int horsepower, int acceleration, int suspension, int durability)
    {
        var car = CarFactory.CreateCar(type, brand, model, yearOfProduction, horsepower, acceleration, suspension, durability);
        cars[id] = car;
    }

    public string Check(int id)
    {
        return cars[id].ToString().Trim();
    }

    public void Open(int id, string type, int length, string route, int prizePool, int goldTime, int laps)
    {
        var race = RaceFactory.CreateRace(type, length, route, prizePool, goldTime, laps);
        races[id] = race;
    }

    public void Participate(int carId, int raceId)
    {
        var car = cars[carId];
        var race = races[raceId];

        if (!garage.ParkedCars.ContainsKey(carId))
        {
            if (race.GetType().Name == "TimeLimitRace" && race.Participants.Count < 1 || race.GetType().Name != "TimeLimitRace")
            {
                races[raceId].Participants[carId] = car;
            }
        }
    }

    public string Start(int id)
    {
        var race = races[id];
        if (race.Participants.Count <= 0)
        {
            return $"Cannot start the race with zero participants.";
        }
        races.Remove(id);
        return race.ToString().Trim();

    }

    public void Park(int id)
    {
        if (!races.Values.Any(x => x.Participants.ContainsKey(id)))
        {
            var car = cars[id];
            garage.ParkedCars.Add(id, car);
        }

    }

    public void Unpark(int id)
    {
        garage.ParkedCars.Remove(id);
    }

    public void Tune(int tuneIndex, string addOn)
    {
        var parkedCars = garage.ParkedCars;
        if (parkedCars.Count > 0)
        {
            foreach (var car in parkedCars)
            {
                car.Value.HorsePower += tuneIndex;
                car.Value.Suspension += tuneIndex / 2;

                var carType = car.Value.GetType().Name;
                switch (carType)
                {
                    case "ShowCar":
                        var showCar = (ShowCar)car.Value;
                        showCar.Stars += tuneIndex;
                        break;

                    case "PerformanceCar":
                        var performanceCar = (PerformanceCar)car.Value;
                        performanceCar.AddOns.Add(addOn);
                        break;
                }
            }
        }
    }
}

