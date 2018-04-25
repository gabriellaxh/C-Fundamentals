using System;
using System.Collections.Generic;
using System.Text;

namespace _02.KingsGambit.Interfaces
{
    interface IAttackable
    {
        string Name { get; set; }
        void RespondToAttack();
    }
}
