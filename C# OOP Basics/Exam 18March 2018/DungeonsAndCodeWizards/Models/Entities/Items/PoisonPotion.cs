using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsAndCodeWizards.Models.Items
{
    public class PoisonPotion : Item
    {
        private const int ppWeight = 5;
        private const int healthDecrement = 20;

        public PoisonPotion() 
            : base(ppWeight)
        {
        }

        public override string Name => "PoisonPotion";

        public override void AffectCharacter(Character character)
        {
            base.AffectCharacter(character);
            character.DecreaseHealth(healthDecrement);
        }
    }
}
