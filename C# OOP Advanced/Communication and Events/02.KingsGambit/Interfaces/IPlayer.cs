using System;
using System.Collections.Generic;
using System.Text;

namespace _02.KingsGambit.Interfaces
{
    interface IPlayer
    {
        string Name { get; set; }

        void RespondToKingUnderAttack(object sender, EventArgs args);
    }
}
