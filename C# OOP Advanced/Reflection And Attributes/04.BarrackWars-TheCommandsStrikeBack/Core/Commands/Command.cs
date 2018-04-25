using _03BarracksFactory.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace _04.BarrackWars_TheCommandsStrikeBack
{
    public class Command : IExecutable
    {
        private string[] date;
        private IRepository repository;
        private IUnitFactory unitFactory;


        public string Execute()
        {
            throw new NotImplementedException();
        }
    }
}
