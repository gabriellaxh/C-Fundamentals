using _02.KingsGambit.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _02.KingsGambit
{
    public class RoyalGuard : IPlayer
    {
        public RoyalGuard(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public void RespondToKingUnderAttack(object sender, EventArgs args)
        {
            Console.WriteLine($"Royal Guard {this.Name} is defending!");
        }
    }
}
