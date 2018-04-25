using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsAndCodeWizards.Models
{
    public abstract class Item
    {
        private int weight;

        public Item(int weight)
        {
            this.Weight = weight;
        }

        public virtual string Name { get; set; }

        public int Weight { get; private set; }

        public virtual void AffectCharacter(Character character)
        {
            character.CheckIfAlive();
        }
    }
}
