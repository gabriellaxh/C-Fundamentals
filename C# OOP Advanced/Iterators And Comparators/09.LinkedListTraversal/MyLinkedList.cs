using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _09.LinkedListTraversal
{
    public class MyLinkedList<T> : IEnumerable<T>
    {
        private LinkedList<T> List { get; set; }

        public MyLinkedList()
        {
            this.List = new LinkedList<T>();
        }

        public void Add(T element)
        {
            this.List.AddLast(element);
        }

        public bool Remove(T element)
        {
            if (this.List.Contains(element))
            {
                this.List.Remove(element);
                return true;
            }
            return false;

        }

        public int Count()
        {
            return this.List.Count;
        }


        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in this.List)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

    }
}
