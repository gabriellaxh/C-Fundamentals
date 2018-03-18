using System;
using System.Collections.Generic;
using System.Linq;

public class Engine
{
    private CarManager manager;

    public Engine()
    {
        this.manager = new CarManager();
    }

    public void Run()
    {
        var command = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
        while (command[0] != "Cops")
        {
            ExecuteCommand(command);

            command = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
        }
    }

    private void ExecuteCommand(List<string> info)
    {
        switch (info[0])
        {
            case "register":
                var id = int.Parse(info[1]);
                var type = info[2];
                var brand = info[3];
                var model = info[4];
                var year = int.Parse(info[5]);
                var horsepower = int.Parse(info[6]);
                var acceleration = int.Parse(info[7]);
                var suspension = int.Parse(info[8]);
                var durability = int.Parse(info[9]);

                this.manager.Register(id, type, brand, model, year, horsepower, acceleration, suspension, durability);
                break;

            case "check":
                var checkId = int.Parse(info[1]);

                Console.WriteLine(this.manager.Check(checkId));
                break;

            case "open":
                var openId = int.Parse(info[1]);
                var openType = info[2];
                var length = int.Parse(info[3]);
                var route = info[4];
                var prizePool = int.Parse(info[5]);
                var goldTime = 0;
                var laps = 0;
                if (openType == "TimeLimit")
                    goldTime = int.Parse(info[6]);
                else if (openType == "Circuit")
                    laps = int.Parse(info[6]);


                this.manager.Open(openId, openType, length, route, prizePool,goldTime,laps);
                break;

            case "participate":
                var carId = int.Parse(info[1]);
                var raceId = int.Parse(info[2]);

                this.manager.Participate(carId, raceId);
                break;

            case "start":
                var raceIdStart = int.Parse(info[1]);

                Console.WriteLine(this.manager.Start(raceIdStart));
                break;

            case "park":
                var carIdPark = int.Parse(info[1]);

                this.manager.Park(carIdPark);
                break;

            case "unpark":
                var carIdUnpark = int.Parse(info[1]);

                this.manager.Unpark(carIdUnpark);
                break;

            case "tune":
                var tuneIndex = int.Parse(info[1]);
                var addOn = info[2];

                this.manager.Tune(tuneIndex, addOn);
                break;

        }
    }
}

