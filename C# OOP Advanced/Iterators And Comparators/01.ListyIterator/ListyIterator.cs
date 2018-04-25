using System;
using System.Collections.Generic;
using System.Text;

namespace _01.ListyIterator
{
    public class ListyIterator<T>
    {
        private readonly List<T> collection;
        private int index;

        public ListyIterator(params T[] collection)
        {
            this.collection = new List<T>(collection);
            this.index = 0;
        }

        public bool Move()
        {
            if (this.index >= this.collection.Count - 1)
                return false;

            else
            {
                this.index++;
                return true;
            }
        }

        public bool HasNext()
        {
            if (this.collection.Count - 1 > this.index)
                return true;
            else
                return false;
        }

        public void Print()
        {
            if(this.collection.Count == 0)
                throw new InvalidOperationException("Invalid Operation!");

            else
                Console.WriteLine(this.collection[index]);
        }
    }
}
