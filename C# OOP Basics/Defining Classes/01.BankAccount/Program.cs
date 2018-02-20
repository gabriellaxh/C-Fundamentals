using System;
using System.Collections.Generic;


    public class Program
    {
        static void Main(string[] args)
        {
            var commands = Console.ReadLine();


            var bankAccounts = new Dictionary<int, BankAccount>();
            while (commands != "End")
            {
                var cmdArgs = commands.Split();
                switch (cmdArgs[0])
                {
                    case "Create":
                        Create(cmdArgs, bankAccounts);
                        break;

                    case "Deposit":
                        Deposit(cmdArgs, bankAccounts);
                        break;

                    case "Withdraw":
                        Withdraw(cmdArgs, bankAccounts);
                        break;

                    case "Print":
                        Print(cmdArgs, bankAccounts);
                        break;
                }
                commands = Console.ReadLine();
            }
        }

        private static void Print(string[] cmdArgs, Dictionary<int, BankAccount> bankAccounts)
        {
            int id = int.Parse(cmdArgs[1]);
            if (bankAccounts.ContainsKey(id))
                Console.WriteLine($"Account ID{id}, balance {bankAccounts[id].Balance:f2}");
            else
                Console.WriteLine("Account does not exist");

        }

        private static void Withdraw(string[] cmdArgs, Dictionary<int, BankAccount> bankAccounts)
        {
            int id = int.Parse(cmdArgs[1]);
            int amount = int.Parse(cmdArgs[2]);
            if (bankAccounts.ContainsKey(id))
            {
                if (bankAccounts[id].Balance - amount >= 0)
                {
                    bankAccounts[id].Balance -= amount;
                }
                else
                {
                    Console.WriteLine("Insufficient balance");
                }
            }
            else
            {
                Console.WriteLine("Account does not exist");
            }
        }

        private static void Deposit(string[] cmdArgs, Dictionary<int, BankAccount> bankAccounts)
        {

            int id = int.Parse(cmdArgs[1]);
            int amount = int.Parse(cmdArgs[2]);
            if (bankAccounts.ContainsKey(id))
            {
                bankAccounts[id].Balance += amount;
            }
            else
            {
                Console.WriteLine("Account does not exist");
            }

        }

        private static void Create(string[] cmdArgs, Dictionary<int, BankAccount> bankAccounts)
        {
            int id = int.Parse(cmdArgs[1]);
            if (bankAccounts.ContainsKey(id))
            {
                Console.WriteLine("Account already exists");
            }
            else
            {
                var newAcc = new BankAccount();
                newAcc.Id = id;
                bankAccounts.Add(id, newAcc);
            }
        }
    }

