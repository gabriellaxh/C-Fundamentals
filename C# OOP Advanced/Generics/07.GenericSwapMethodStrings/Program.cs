using System;

namespace GenericSwapMethodString
{
    public class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            var collection = new GenericCollection<string>();

            for (int i = 0; i < count; i++)
            {
                var element = Console.ReadLine();
                collection.AddElement(element);
            }

            string[] indexes = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int firstIndex = int.Parse(indexes[0]);
            int secondIndex = int.Parse(indexes[1]);
            collection.SwapElements(firstIndex, secondIndex);

            collection.Print();
        }
    }
}
