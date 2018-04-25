using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericCountMethodStrings
{
    public class Program
    {
        static void Main(string[] args)
        {
            var collection = GetCollection();
            var comparator = Console.ReadLine();

            Console.WriteLine(CountElements(collection, comparator));
        }


        public static int CountElements<Т>(List<IComparable> collection, Т element)
        {
            return collection.Count(x => x.CompareTo(element) > 0);
        }

        private static List<IComparable> GetCollection()
        {
            int num = int.Parse(Console.ReadLine());
            var collection = new List<IComparable>();

            for (int i = 0; i < num; i++)
            {
                collection.Add(Console.ReadLine());
            }
            return collection;
        }
    }
}
