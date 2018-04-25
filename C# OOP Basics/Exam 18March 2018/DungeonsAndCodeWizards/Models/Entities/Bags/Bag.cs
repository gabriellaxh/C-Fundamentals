using System;
using System.Collections.Generic;
using System.Linq;

namespace DungeonsAndCodeWizards.Models
{
    public abstract class Bag
    {
        private int capacity;
        private List<Item> items;

        public Bag(int capacity)
        {
            this.Capacity = capacity;
            this.items = new List<Item>();
        }

        public int Load => this.items.Sum(i => i.Weight);

        public int Capacity
        {
            get => this.capacity;
            private set => this.capacity = value;
        }

        public IReadOnlyCollection<Item> Items => this.items.AsReadOnly();


        public void AddItem(Item item)
        {
            if (this.Load + item.Weight > this.Capacity)
                throw new InvalidOperationException(Constants.FullBag);

            this.items.Add(item);
        }

        public Item GetItem(string name)
        {
            if (this.items.Count == 0)
                throw new InvalidOperationException(Constants.EmptyBag);

            Item item_ = this.items.FirstOrDefault(x => x.Name == name);
            if (item_ == null)
                throw new InvalidOperationException(string.Format(Constants.InvalidItemName, item_.Name));

            this.items.Remove(item_);
            return item_;
        }
    }
}