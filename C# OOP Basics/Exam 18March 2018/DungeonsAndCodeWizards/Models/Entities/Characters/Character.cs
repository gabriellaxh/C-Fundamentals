using System;

namespace DungeonsAndCodeWizards.Models
{
    public abstract class Character
    {
        private string name;
        private double baseHealth;
        private double health;
        private double baseArmor;
        private double armor;
        private double abilityPoints;
        private Bag bag;
        private Faction faction;
        private bool isAlive;

        public Character(string name, double health, double armor, double abilityPoints, Bag bag, Faction faction)
        {
            this.Name = name;

            this.BaseHealth = health;
            this.Health = health;

            this.BaseArmor = armor;
            this.Armor = armor;

            this.AbilityPoints = abilityPoints;

            this.Bag = bag;

            this.Faction = faction;

            this.isAlive = true;
        }

        public virtual double RestHealMultiplier => 0.2;

        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Name cannot be null or whitespace!");

                this.name = value;
            }
        }

        public double BaseHealth
        {
            get => this.baseHealth;
            private set => this.baseHealth = value;
        }

        public double Health
        {
            get => this.health;
            set
            {
                if (value <= 0)
                {
                    this.health = 0;
                    this.IsAlive = false;
                }

                else if (value >= baseHealth)
                    this.health = baseHealth;

                else
                    this.health = value;
            }
        }

        public double BaseArmor
        {
            get => this.baseArmor;
            private set => this.baseArmor = value;
        }

        public double Armor
        {
            get => this.armor;
            private set
            {
                if (value <= 0)
                    this.armor = 0;

                else if (value >= baseArmor)
                    this.armor = baseArmor;

                else
                    this.armor = value;
            }
        }

        public double AbilityPoints
        {
            get => this.abilityPoints;
            private set => this.abilityPoints = value;
        }

        public Bag Bag
        {
            get => this.bag;
            private set => this.bag = value;
        }

        public Faction Faction
        {
            get => this.faction;
            private set => this.faction = value;
        }

        public bool IsAlive
        {
            get => this.isAlive;
            private set => this.isAlive = value;
        }


        public void IncreaseHealth(int amount)
        {
            this.Health += Math.Min(amount, this.BaseHealth);
        }
        public void DecreaseHealth(int amount)
        {
            this.Health -= amount;
        }
        public void RestoreArmor()
        {
            this.Armor = this.BaseArmor;
        }
        public void CheckIfAlive()
        {
            if(!this.IsAlive)
                throw new InvalidOperationException(Constants.CharacterNotAlive);
        }

        public void TakeDamage(double hitPoints)
        {
            this.CheckIfAlive();

            if (hitPoints > this.Armor)
            {
                var afterHitPoints = hitPoints - this.Armor;
                this.Health -= afterHitPoints;
            }
            this.Armor -= hitPoints;

        }

        public void Rest()
        {
            this.CheckIfAlive();

            this.Health += this.BaseHealth * this.RestHealMultiplier;
        }

        public void UseItem(Item item)
        {
            this.CheckIfAlive();

            item.AffectCharacter(this);
        }

        public void UseItemOn(Item item,Character character)
        {
            this.CheckIfAlive();
            character.CheckIfAlive();

            item.AffectCharacter(character);
        }

        public void GiveCharacterItem(Item item,Character character)
        {
            this.CheckIfAlive();
            character.CheckIfAlive();

            character.ReceiveItem(item);
        }

        public void ReceiveItem(Item item)
        {
            this.CheckIfAlive();
            this.Bag.AddItem(item);
        }
    }
}