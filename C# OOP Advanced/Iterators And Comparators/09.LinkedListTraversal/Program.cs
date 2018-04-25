using System;

namespace _09.LinkedListTraversal
{
    public class Program
    {
        static void Main(string[] args)
        {
            var collection = new MyLinkedList<int>();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                var info = Console.ReadLine().Split();
                switch (info[0])
                {
                    case "Add":
                        collection.Add(int.Parse(info[1]));
                        break;

                    case "Remove":
                       collection.Remove(int.Parse(info[1]));
                        break;
                }
            }
            Console.WriteLine(collection.Count());
            Console.WriteLine(string.Join(" ",collection));
        }
    }
}
