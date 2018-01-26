using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_6._Truck_Tour
{
    public class Program
    {
        static void Main(string[] args)
                        {
            var pumpsCount = int.Parse(Console.ReadLine());
            var pumps = new Queue<int[]>();
            for (int i = 0; i < pumpsCount; i++)
            {
                var pump = Console.ReadLine()
                                    .Split()
                                    .Select(int.Parse)
                                    .ToArray();
                pumps.Enqueue(pump);
            }

            for (int i = 0; i < pumpsCount; i++)
            {
                int fuel = 0;
                bool isCompleted = true;

                foreach (var pump in pumps)
                {
                    int pumpFuel = pump[0];
                    int distance = pump[1];

                    fuel += pumpFuel;
                    if(fuel < distance)
                    {
                        isCompleted = false;
                        pumps.Enqueue(pumps.Dequeue());
                        break;
                    }
                    fuel -= distance;
                }

                if (isCompleted)
                {
                    Console.WriteLine(i);
                    return;
                }

            }
        }
    }
}
