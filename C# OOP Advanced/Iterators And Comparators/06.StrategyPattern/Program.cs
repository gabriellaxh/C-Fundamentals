using System;
using System.Collections.Generic;

namespace _06.StrategyPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            var sortedByName = new SortedSet<Person>(new NameComparator());
            var sortedByAge = new SortedSet<Person>(new AgeComparator());

            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                var info = Console.ReadLine().Split();
                string name = info[0];
                int age = int.Parse(info[1]);

                sortedByName.Add(new Person(name, age));
                sortedByAge.Add(new Person(name, age));
            }
            foreach (var per in sortedByName)
            {
                Console.WriteLine($"{per.Name} {per.Age}");
            }

            foreach (var pers in sortedByAge)
            {
                Console.WriteLine($"{pers.Name} {pers.Age}");
            }

        }
    }
}
