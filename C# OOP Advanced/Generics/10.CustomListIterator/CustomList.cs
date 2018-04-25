using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09.CustomListSorter
{
    public class CustomList<T> : IEnumerable<T>
        where T : IComparable<T>
    {
        private List<T> collection;

        public List<T> Elements => this.collection;

        public CustomList()
            :this(new List<T>())
        {
          

        }

        public CustomList(List<T> collection)
        {
            this.collection = collection;
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

        //public void Print()
        //{
        //    foreach (var item in this.collection)
        //    {
        //        Console.WriteLine((item.ToString()));
        //    }
        //}

        public IEnumerator<T> GetEnumerator()
        {
            return this.Elements.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
