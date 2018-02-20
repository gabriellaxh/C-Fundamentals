using System;


public class StartUp
{
    static void Main(string[] args)
    {
        int count = int.Parse(Console.ReadLine());

        var newFam = new Family();
        for (int i = 0; i < count; i++)
        {
            var info = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var newMember = new Person()
            {
                Name = info[0],
                Age = int.Parse(info[1])
            };
            newFam.AddMember(newMember);
        }
        var oldest = newFam.GetOldestMember();
        if (oldest != null)
            Console.WriteLine($"{oldest.Name} {oldest.Age}");
    }
}

