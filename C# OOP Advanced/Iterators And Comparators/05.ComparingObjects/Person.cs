using System;
using System.Collections.Generic;
using System.Text;

namespace _05.ComparingObjects
{
    public class Person : IComparable<Person>
    {
        public string Name;
        public int Age;
        public string Town;

        public Person(string name, int age, string town)
        {
            this.Name = name;
            this.Age = age;
            this.Town = town;
        }

        public int CompareTo(Person other)
        {
            var comparing = string.Compare(this.Name, other.Name, StringComparison.InvariantCulture);

            if (comparing == 0)
                comparing = this.Age.CompareTo(other.Age);

            if (comparing == 0)
                comparing = string.Compare(this.Name, other.Name, StringComparison.InvariantCulture);

            return comparing;
        }
    }
}
