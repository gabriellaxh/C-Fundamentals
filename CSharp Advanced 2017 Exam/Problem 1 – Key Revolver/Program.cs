using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            long bulletPrice = long.Parse(Console.ReadLine());
            long barrelSize = long.Parse(Console.ReadLine());
            var bullets = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                            .Select(long.Parse)
                                            .ToList();
            var locks = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                            .Select(long.Parse)
                                            .ToList();
            var valueOfIntelligence = long.Parse(Console.ReadLine());

            var bulletsQueue = new Stack<long>();
            foreach (var bullet in bullets)
            {
                bulletsQueue.Push(bullet);
            }

            var locksStack = new Queue<long>();
            foreach (var lock_ in locks)
            {
                locksStack.Enqueue(lock_);
            }

            long bulletCounter = 0;
            long bulletsTotalCost = 0;

            
            while (bulletsQueue.Count != 0 && locksStack.Count != 0)
            {
                if (bulletCounter == barrelSize)
                {
                    Console.WriteLine("Reloading!");
                    bulletCounter = 0;
                }

                var bulletShoot = bulletsQueue.Pop();
                var lockk = locksStack.Peek();

                if (bulletShoot <= lockk)
                {
                    Console.WriteLine("Bang!");
                    locksStack.Dequeue();
                    bulletCounter++;
                    bulletsTotalCost += bulletPrice;
                }
                else
                {
                    Console.WriteLine("Ping!");
                    bulletCounter++;
                    bulletsTotalCost += bulletPrice;
                }
            }
            if (bulletsQueue.Count == 0 && locksStack.Count > 0)
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locksStack.Count}");
            }
            else if(bulletsQueue.Count >= barrelSize && locksStack.Count == 0)
            {
                Console.WriteLine("Reloading!");
                Console.WriteLine($"{bulletsQueue.Count} bullets left. Earned ${valueOfIntelligence - bulletsTotalCost}");
            }
            else
            {
                Console.WriteLine($"{bulletsQueue.Count} bullets left. Earned ${valueOfIntelligence - bulletsTotalCost}");
            }
        }
    }
}
