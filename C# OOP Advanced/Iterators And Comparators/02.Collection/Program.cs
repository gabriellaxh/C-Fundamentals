using _01.ListyIterator;
using System;
using System.Linq;

namespace _02.Collection
{
    public class Program
    {
        static void Main(string[] args)
        {
            var collection = new ListyIterator<string>();

            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                var command = input.Split().ToArray();
                try
                {
                    switch (command[0])
                    {
                        case "Create":
                            var elements = command.Skip(1).ToArray();
                            collection = new ListyIterator<string>(elements);
                            break;

                        case "Move":
                            Console.WriteLine(collection.Move());
                            break;

                        case "HasNext":
                            Console.WriteLine(collection.HasNext());
                            break;

                        case "Print":
                            collection.Print();
                            break;

                        case "PrintAll":
                            foreach (var item in collection)
                            {
                                Console.Write(item + " ");
                            }
                            Console.WriteLine();
                            break;
                    }
                }

                catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
