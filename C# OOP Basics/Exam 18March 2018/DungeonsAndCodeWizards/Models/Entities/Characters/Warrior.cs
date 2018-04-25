using DungeonsAndCodeWizards.Models.Bags;
using DungeonsAndCodeWizards.Models.Interfaces;
using System;

namespace DungeonsAndCodeWizards.Models.Entities.Characters
{
    public class Warrior : Character, IAttackable
    {
        public Warrior(string name, Faction faction)
            : base(name, 100, 50, 40, new Satchel(), faction)
        {

        }

        public void Attack(Character character)
        {
            character.CheckIfAlive();
            this.CheckIfAlive();

            if (this == character)
                throw new InvalidOperationException(Constants.SelfAttack);

            if (this.Faction == character.Faction)
                throw new ArgumentException(string.Format(Constants.SameFaction, this.Faction));

            character.TakeDamage(this.AbilityPoints);
        }
    }
}
