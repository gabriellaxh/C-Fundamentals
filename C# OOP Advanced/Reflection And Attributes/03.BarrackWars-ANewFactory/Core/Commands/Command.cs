using _03BarracksFactory.Contracts;

namespace _04.BarrackWars_TheCommandsStrikeBack
{
    public abstract class Command : IExecutable
    {
        private string[] data;
          

        public Command(string[] data)
        {
            this.Data = data;
        }

        protected string[] Data
        {
            get => this.data;
            private set { this.data = value; }
        }

        
        public abstract string Execute();
    }
}
