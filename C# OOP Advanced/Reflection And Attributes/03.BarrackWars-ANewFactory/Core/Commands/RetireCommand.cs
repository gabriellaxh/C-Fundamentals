using _03BarracksFactory.Contracts;
using System;

namespace _04.BarrackWars_TheCommandsStrikeBack
{
    public class RetireCommand : Command
    {
        private IRepository repository;

        public RetireCommand(string[] data, IRepository repository)
            : base(data)
        {
            this.Repository = repository;
        }

        protected IRepository Repository
        {
            get => this.repository;
            private set { this.repository = value; }
        }

      
        public override string Execute()
        {
            string unitType = Data[1];

            this.Repository.RemoveUnit(unitType);
            return $"{unitType} retired!";


        }
    }
}
