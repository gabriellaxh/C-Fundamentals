using DungeonsAndCodeWizards.Factories;
using DungeonsAndCodeWizards.Models;
using DungeonsAndCodeWizards.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DungeonsAndCodeWizards.Controllers
{
    public class DungeonMaster
    {
        public CharacterFactory characterFactory;
        public ItemFactory itemFactory;

        public List<Character> characterParty;
        public List<Item> itemPool;
        public int lastSurvivorConsecutiveRounds;

        public DungeonMaster()
        {
            this.characterFactory = new CharacterFactory();
            this.itemFactory = new ItemFactory();
            this.characterParty = new List<Character>();
            this.itemPool = new List<Item>();
        }

        public string JoinParty(string[] args)
        {
            string faction = args[0];
            string characterType = args[1];
            string name = args[2];

            Character character = this.characterFactory.CreateCharacter(faction, characterType, name);
            this.characterParty.Add(character);

            return string.Format(Constants.SuccessfullyJoinedParty, name);
        }

        public string AddItemToPool(string[] args)
        {
            string itemName = args[0];

            Item item = this.itemFactory.CreateItem(itemName);
            this.itemPool.Add(item);

            return string.Format(Constants.SuccessfullyAddedToPool, itemName);
        }

        public string PickUpItem(string[] args)
        {
            string characterName = args[0];

            Character character = this.characterParty.FirstOrDefault(x => x.Name == characterName);

            if (character == null)
                throw new ArgumentException(string.Format(Constants.CharacterNotFound, characterName));

            if (this.itemPool.Count == 0)
                throw new InvalidOperationException(string.Format(Constants.EmptyPool));

            Item item = this.itemPool.Last();
            this.itemPool.Remove(item);

            character.ReceiveItem(item);
            return string.Format(Constants.SuccessfullyPickedUpItem, characterName, item.Name);
        }

        public string UseItem(string[] args)
        {
            string characterName = args[0];
            string itemName = args[1];

            Character character = this.characterParty.FirstOrDefault(x => x.Name == characterName);

            if (character.Bag.Items.Count == 0)
                throw new InvalidOperationException(Constants.EmptyBag);

            Item item = character.Bag.Items.FirstOrDefault(x => x.Name == itemName);

            if (character == null)
                throw new ArgumentException(string.Format(Constants.CharacterNotFound, characterName));

            if (item == null)
                throw new ArgumentException(string.Format(Constants.NoSuchItemInBag, itemName));

            character.UseItem(character.Bag.GetItem(itemName));

            return string.Format(Constants.UsedItem, characterName, itemName);
        }

        public string UseItemOn(string[] args)
        {
            string giverName = args[0];
            string receiverName = args[1];
            string itemName = args[2];

            Character giver = this.characterParty.FirstOrDefault(x => x.Name == giverName);
            Character receiver = this.characterParty.FirstOrDefault(x => x.Name == receiverName);
            Item item = giver.Bag.GetItem(itemName);


            if (giver == null)
                throw new ArgumentException(string.Format(Constants.CharacterNotFound, giverName));
            if (receiver == null)
                throw new ArgumentException(string.Format(Constants.CharacterNotFound, receiverName));
            if (item == null)
                throw new ArgumentException(string.Format(Constants.ItemNotFound, itemName));

            giver.UseItemOn(item, receiver);
            return string.Format(Constants.UsedItemOn, giverName, itemName, receiverName);
        }

        public string GiveCharacterItem(string[] args)
        {
            string giverName = args[0];
            string receiverName = args[1];
            string itemName = args[2];

            Character giver = this.characterParty.FirstOrDefault(x => x.Name == giverName);
            Character receiver = this.characterParty.FirstOrDefault(x => x.Name == receiverName);
            Item item = giver.Bag.GetItem(itemName);


            if (giver == null)
                throw new ArgumentException(string.Format(Constants.CharacterNotFound, giverName));
            if (receiver == null)
                throw new ArgumentException(string.Format(Constants.CharacterNotFound, receiverName));
            if (item == null)
                throw new ArgumentException(string.Format(Constants.ItemNotFound, itemName));

            receiver.ReceiveItem(item);
            return string.Format(Constants.GaveItem, giverName, receiverName, itemName);

        }

        public string GetStats()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var @char in characterParty.OrderByDescending(x => x.IsAlive)
                                                    .ThenByDescending(x => x.Health))
            {
                if (@char.IsAlive == true)
                    sb.AppendLine($"{@char.Name} - HP: {@char.Health}/{@char.BaseHealth}, AP: {@char.Armor}/{@char.BaseArmor}, Status: Alive");
                else
                    sb.AppendLine($"{@char.Name} - HP: {@char.Health}/{@char.BaseHealth}, AP: {@char.Armor}/{@char.BaseArmor}, Status: Dead");

            }

            return sb.ToString().Trim();
        }

        public string Attack(string[] args)
        {
            string attackerName = args[0];
            string receiverName = args[1];

            Character attacker = this.characterParty.FirstOrDefault(x => x.Name == attackerName);
            Character receiver = this.characterParty.FirstOrDefault(x => x.Name == receiverName);

            if (attacker == null)
                throw new ArgumentException(string.Format(Constants.CharacterNotFound, attackerName));
            if (receiver == null)
                throw new ArgumentException(string.Format(Constants.CharacterNotFound, receiverName));


            StringBuilder sb = new StringBuilder();

            if (!(attacker is IAttackable currentAttacker))
                throw new ArgumentException(string.Format(Constants.NotAttackable, attackerName));

            else
            {
                currentAttacker.Attack(receiver);

                sb.AppendLine($"{attackerName} attacks {receiverName} for {attacker.AbilityPoints} hit points! " +
                    $"{receiverName} has {receiver.Health}/{receiver.BaseHealth} HP and {receiver.Armor}/{receiver.BaseArmor} AP left!");

                if (receiver.IsAlive == false)
                    sb.AppendLine($"{receiverName} is dead!");
            }

            return sb.ToString().Trim();
        }

        public string Heal(string[] args)
        {
            string healerName = args[0];
            string healingReceiverName = args[1];

            Character healer = this.characterParty.FirstOrDefault(x => x.Name == healerName);
            Character receiver = this.characterParty.FirstOrDefault(x => x.Name == healingReceiverName);

            if (healer == null)
                throw new ArgumentException(string.Format(Constants.CharacterNotFound, healerName));

            if (healingReceiverName == null)
                throw new ArgumentException(string.Format(Constants.CharacterNotFound, healingReceiverName));

            if (!(healer is IHealable currentHealer))
                throw new ArgumentException(string.Format(Constants.NotHealable, healerName));

            currentHealer.Heal(receiver);
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{healerName} heals {healingReceiverName} for {healer.AbilityPoints}! " +
                $"{healingReceiverName} has {receiver.Health} health now!");

            return sb.ToString().Trim();
        }

        public string EndTurn(string[] args)
        {
            List<Character> aliveCharacters = this.characterParty
                                                   .Where(x => x.IsAlive == true)
                                                   .ToList();
            if (aliveCharacters.Count < 2)
                lastSurvivorConsecutiveRounds++;

            StringBuilder sb = new StringBuilder();
            foreach (var charr in aliveCharacters)
            {
                double healthBefore = charr.Health;
                charr.Rest();
                double healthAfter = charr.Health;
                sb.AppendLine($"{charr.Name} rests ({healthBefore} => {healthAfter})");
            }
            return sb.ToString().Trim();
        }

        public bool IsGameOver()
        {
            if (lastSurvivorConsecutiveRounds > 1 && this.characterParty.Count <= 1)
                return true;

            return false;
        }
    }
}
