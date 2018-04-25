using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _03.Stack
{
    public class Stack<T> : IEnumerable<T>
    {
        private List<T> collection;

        public Stack()
        {
            this.collection = new List<T>();
        }

        public void Push(T item)
        {
            this.collection.Add(item);
        }

        public void Pop()
        {
            if (!this.collection.Any())
            {
                throw new ArgumentException("No elements");
            }
             this.collection.RemoveAt(this.collection.Count - 1);
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = collection.Count-1; i >= 0; i--)
            {
                yield return this.collection[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
