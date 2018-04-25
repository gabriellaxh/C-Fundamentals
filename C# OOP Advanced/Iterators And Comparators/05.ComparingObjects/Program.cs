using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.ComparingObjects
{
    public class Program
    {
        static void Main(string[] args)
        {
            var people = new List<Person>();

            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                var info = input.Split().ToArray();
                string name = info[0];
                int age = int.Parse(info[1]);
                string town = info[2];

                people.Add(new Person(name, age, town));
            }

            int num = int.Parse(Console.ReadLine());
            var person = people[num - 1];
            var peopleCount = people.Count();

            int count = 0;
            people.Remove(person);

            foreach (var pers in people)
            {
                if (pers.CompareTo(person) == 0)
                    count++;
            }

            if (count == 0)
                Console.WriteLine("No matches");
            else
                Console.WriteLine($"{count+1} {people.Count - count} {peopleCount}");
        }
    }
}
