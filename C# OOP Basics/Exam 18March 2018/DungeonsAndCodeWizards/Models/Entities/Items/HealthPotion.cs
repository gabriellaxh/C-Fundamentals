using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsAndCodeWizards.Models.Items
{
    public class HealthPotion : Item
    {
        private const int hpWeight = 5;
        private const int healthIncrement = 20;

        public HealthPotion()
            :base(hpWeight)
        {
            
        }

        public override string Name => "HealthPotion";

        public override void AffectCharacter(Character character)
        {
            base.AffectCharacter(character);
            character.IncreaseHealth(healthIncrement);
        }
    }
}
