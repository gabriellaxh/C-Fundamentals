using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsAndCodeWizards.Models.Items
{
    public class ArmorRepairKit : Item
    {
        private const int arkWeight = 10;

        public ArmorRepairKit() 
            : base(arkWeight)
        {
        }

        public override string Name => "ArmorRepairKit";

        public override void AffectCharacter(Character character)
        {
            base.AffectCharacter(character);
            character.RestoreArmor();
        }
    }
}
