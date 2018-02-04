using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_7._Predicate_for_Names
{
    public class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            var names = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Predicate<string> isValid = x => x.Length <= length;
            var list = new List<string>();

            names.Where(x => isValid(x)).ToList().ForEach(x=> Console.WriteLine(x));

        }
    }
}
