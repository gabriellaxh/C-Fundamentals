using _02.KingsGambit.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _02.KingsGambit
{
    public class Footman : IPlayer
    {
        public Footman(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }
        
        public void RespondToKingUnderAttack(object sender, EventArgs args)
        {
            Console.WriteLine($"Footman {this.Name} is panicking!");
        }
    }
}
