using System.Collections.Generic;

namespace GenericSwapMethodString
{
    public class GenericCollection<T>
    {
        private List<T> collection;

        public GenericCollection()
        {
            this.collection = new List<T>();
        }

        public void AddElement(T element)
        {
            this.collection.Add(element);
        }

        public void SwapElements(int first, int second)
        {
            T firstEl = collection[first];
            collection[first] = collection[second];
            collection[second] = firstEl;
        }

        public void Print()
        {
            foreach (var el in collection)
            {
                System.Console.WriteLine($"{el.GetType().FullName}: {el}");
            }
        }
    }
}
