using System;

namespace _01.EventImplementation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var dispatcher = new Dispatcher();
            var handler = new Handler();

            dispatcher.NameChange += handler.OnDispatcherNameChange;

            string input;
            while((input = Console.ReadLine()) != "End")
            {
                dispatcher.Name = input;
            }
        }
    }
}
