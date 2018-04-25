using System;
using System.Collections.Generic;

namespace _07.EqualityLogic
{
    public class Program
    {
        static void Main(string[] args)
        {
            var sortedSet = new SortedSet<Person>();
            var hashSet = new HashSet<Person>();

            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                var info = Console.ReadLine().Split();
                string name = info[0];
                int age = int.Parse(info[1]);

                var newPerson = new Person(name, age);
                sortedSet.Add(newPerson);
                hashSet.Add(newPerson);
            }
            Console.WriteLine(sortedSet.Count);
            Console.WriteLine(hashSet.Count);
        }
    }
}
