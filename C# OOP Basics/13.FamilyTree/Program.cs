using System;
using System.Collections.Generic;
using System.Globalization;

public class Program
{
    static void Main(string[] args)
    {
        var line = Console.ReadLine();

        var children = new List<Member>();
        var parents = new List<Member>();
        var family = new List<Member>();

        var member = new Member();

        DateTime date;
        DateTime.TryParseExact(line,"dd/MM/yyyy",CultureInfo.InvariantCulture,DateTimeStyles.None ,out date);
        if(date.Year != 1)
        {
            member.DateOfBirth = date;
        }
        else
        {
            member.Name = line;
        }

        var info = Console.ReadLine();
        while(info != "End")
        {
            var info_ = info.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if(info_.Length == 3)
            {

            }
        }
    }
}

