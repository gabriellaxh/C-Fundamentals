using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08.CustomList
{
    public class CustomList<T>
        where T : IComparable<T>
    {
        private List<T> collection;

        public CustomList()
        {
            this.collection = new List<T>();
        }

        public void Add(T element)
        {
            this.collection.Add(element);
        }

        public void Remove(int index)
        {
            this.collection.RemoveAt(index);
        }

        public bool Contains(T element)
        {
            return this.collection.Contains(element);
        }

        public void Swap(int indexOne, int indexTwo)
        {
            var index = this.collection[indexOne];
            this.collection[indexOne] = this.collection[indexTwo];
            this.collection[indexTwo] = index;
        }

        public int Greater(T element)
        {
            return this.collection.Count(x => x.CompareTo(element) > 0);
        }

        public T Max()
        {
            return this.collection.Max();
        }

        public T Min()
        {
            return this.collection.Min();
        }

        public void Print()
        {
            foreach (var item in this.collection)
            {
                Console.WriteLine((item.ToString()));
            }
        }
    }
}
