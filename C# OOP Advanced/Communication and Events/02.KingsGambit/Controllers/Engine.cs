using _02.KingsGambit.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.KingsGambit.Controllers
{
    public class Engine
    {
        private List<IPlayer> players = new List<IPlayer>();
        private King king;

        public Engine()
        {
            this.players = new List<IPlayer>();
        }
        public void Run()
        {
            StartAKingdom();
            ExecuteCommands();
        }

        private void ExecuteCommands()
        {
            var input = Console.ReadLine().Split();

            while (input[0] != "End")
            {
                switch (input[0])
                {
                    case "Attack":
                        this.king.RespondToAttack();
                        break;

                    case "Kill":
                        this.RemovePlayer(input[1]);
                        break;
                }

                input = Console.ReadLine().Split();
            }
        }

        private void RemovePlayer(string name)
        {
            var player = this.players.FirstOrDefault(x => x.Name == name);
            king.UnderAttack -= player.RespondToKingUnderAttack;
            this.players.Remove(player);
        }

        private void StartAKingdom()
        {
            this.king = new King(Console.ReadLine());

            string[] royalGuards = Console.ReadLine().Split();
            foreach (var guard in royalGuards)
            {
                var royalGuard = new RoyalGuard(guard);
                this.players.Add(royalGuard);
                king.UnderAttack += royalGuard.RespondToKingUnderAttack;
            }

            string[] footmans = Console.ReadLine().Split();
            foreach (var footman in footmans)
            {
                var newFootman = new Footman(footman);
                this.players.Add(newFootman);
                king.UnderAttack += newFootman.RespondToKingUnderAttack;
            }

        }
    }
}
