using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsAndCodeWizards.Models.Bags
{
    public class Backpack : Bag
    {
        private const int bpCapacity = 100;

        public Backpack() 
            : base(bpCapacity)
        {
        }
    }
}
