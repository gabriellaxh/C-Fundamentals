using DungeonsAndCodeWizards.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DungeonsAndCodeWizards.Core
{
    public class Engine
    {
        private DungeonMaster master;
        private bool isGameOver;

        public Engine()
        {
            this.master = new DungeonMaster();
            this.isGameOver = false;
        }

        public void Run()
        {
            string input;
           
            while(!isGameOver)
            {
                input = Console.ReadLine();
                try
                {
                    if (string.IsNullOrWhiteSpace(input))
                    {
                        this.isGameOver = true;
                        break;
                    }

                    List<string> command = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                    string commandName = command[0];
                    string[] arguments = command.Skip(1).ToArray();

                    ProcessCommand(commandName, arguments);

                }
                catch(Exception ex)
                {
                    if(ex is ArgumentException)
                        Console.WriteLine($"Parameter Error: {ex.Message}");

                    else if(ex is InvalidOperationException)
                        Console.WriteLine($"Invalid Operation: {ex.Message}");
                }
            }
            Console.WriteLine("Final stats:");
            Console.WriteLine(this.master.GetStats());
        }

        private void ProcessCommand(string commandName, string[] arguments)
        {
            string output = string.Empty;

            switch (commandName)
            {
                case "JoinParty":
                    output = this.master.JoinParty(arguments);
                    break;

                case "AddItemToPool":
                    output = this.master.AddItemToPool(arguments);
                    break;

                case "PickUpItem":
                    output = this.master.PickUpItem(arguments);
                    break;

                case "UseItem":
                    output = this.master.UseItem(arguments);
                    break;

                case "UseItemOn":
                    output = this.master.UseItemOn(arguments);
                    break;

                case "GiveCharacterItem":
                    output = this.master.GiveCharacterItem(arguments);
                    break;

                case "GetStats":
                    output = this.master.GetStats();
                    break;

                case "Attack":
                    output = this.master.Attack(arguments);
                    break;

                case "Heal":
                    output = this.master.Heal(arguments);
                    break;

                case "EndTurn":
                    output = this.master.EndTurn(arguments);
                    break;

                case "IsGameOver":
                    this.master.IsGameOver();
                    break;
            }

            if(output != string.Empty)
                Console.WriteLine(output);
        }
    }
}
