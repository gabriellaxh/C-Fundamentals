using _02.KingsGambit.Interfaces;
using System;

namespace _02.KingsGambit
{
    public class King : IAttackable
    {
        public event EventHandler UnderAttack;

        public King(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public void RespondToAttack()
        {
           Console.WriteLine($"King {this.Name} is under attack!");
             this.UnderAttack?.Invoke(this, new EventArgs());
        }
    }
}

