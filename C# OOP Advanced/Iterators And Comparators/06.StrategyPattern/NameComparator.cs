using _06.StrategyPattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace _06.StrategyPattern
{
    public class NameComparator : IComparer<Person>
{
    public int Compare(Person x, Person y)
    {
        int comparing = x.Name.Length.CompareTo(y.Name.Length);

        if (comparing == 0)
            comparing = char.ToLower(x.Name[0]).CompareTo(char.ToLower(y.Name[0]));

        return comparing;
    }
}
}
