using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_1._Action_Point
{
    public class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine()
                                      .Split(new[] { ' ' },StringSplitOptions.RemoveEmptyEntries);
            Action<string> print = x => Console.WriteLine(x);

            foreach (var name in names)
            {
                print(name);
            }
            
        }
    }
}
