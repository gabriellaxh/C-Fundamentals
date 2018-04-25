using DungeonsAndCodeWizards.Models.Bags;
using DungeonsAndCodeWizards.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsAndCodeWizards.Models.Entities.Characters
{
    public class Cleric : Character, IHealable
    {
        private const int baseHealth = 50;
        private const int baseArmor = 25;
        private const int abilityPoints = 40;

        public override double RestHealMultiplier => 0.5;

        public Cleric(string name, Faction faction) 
            : base(name, baseHealth, baseArmor, abilityPoints, new Backpack(), faction)
        {
        }

        public void Heal(Character character)
        {
            this.CheckIfAlive();
            character.CheckIfAlive();

            if (this.Faction != character.Faction)
                throw new InvalidOperationException(Constants.DifferentFaction);

            character.IncreaseHealth(abilityPoints);
        }
    }
}
