using System;
using System.Collections.Generic;
using System.Text;
using _03BarracksFactory.Contracts;

namespace _04.BarrackWars_TheCommandsStrikeBack
{
    public class ReportCommand : Command
    {
        private IRepository repository;

        public ReportCommand(string[] data, IRepository repository)
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
            string output = this.Repository.Statistics;
            return output;
        }
    }
}
