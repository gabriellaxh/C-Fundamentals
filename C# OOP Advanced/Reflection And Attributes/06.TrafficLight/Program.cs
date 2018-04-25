using System;
using System.Collections.Generic;

namespace _06.TrafficLight
{
    public class Program
    {
        static void Main(string[] args)
        {
            var listOfLights = new List<ITrafficLight>();

            var input = Console.ReadLine().Split();
            int times = int.Parse(Console.ReadLine());

            foreach (var line in input)
            {
                listOfLights.Add(new TrafficLight(line));
            }

            for (int i = 0; i < times; i++)
            {
                listOfLights.ForEach(x => x.ChangeLights());

                Console.WriteLine(string.Join(" ", listOfLights));
            }

        }
    }
}
