using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Family
{
    private List<Person> people { get; set; }

    public Family()
    {
        this.people = new List<Person>();
    }

    public void AddMember(Person member)
    {
        if (!people.Contains(member))
        {
            people.Add(member);
        }
    }

    public Person GetOldestMember()
    {
        return people.OrderByDescending(x => x.Age).FirstOrDefault();
    }
}

