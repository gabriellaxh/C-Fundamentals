using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsAndCodeWizards
{
    public static class Constants
    {
        public const string CharacterNotAlive = "Must be alive to perform this action!";

        public const string EmptyBag = "Bag is empty!";

        public const string FullBag = "Bag is full!";

        public const string InvalidItemName = "Invalid item \"{0}\"!";

        public const string SelfAttack = "Cannot attack self!";

        public const string SameFaction = "Friendly fire! Both characters are from {0} faction!";

        public const string DifferentFaction = "Cannot heal enemy character!";

        public const string InvalidFaction = "Invalid faction \"{0}\"!";

        public const string InvalidCharacterType = "Invalid character type \"{0}\"!";

        public const string InvalidItemType = "Invalid item \"{0}\"!";

        public const string SuccessfullyJoinedParty = "{0} joined the party!";

        public const string SuccessfullyAddedToPool = "{0} added to pool.";

        public const string CharacterNotFound = "Character {0} not found!";

        public const string ItemNotFound = "Item {0} not found!";

        public const string NoSuchItemInBag = "No item with name {0} in bag!";

        public const string EmptyPool = "No items left in pool!";

        public const string SuccessfullyPickedUpItem = "{0} picked up {1}!";

        public const string UsedItem = "{0} used {1}.";

        public const string UsedItemOn = "{0} used {1} on {2}.";

        public const string GaveItem = "{0} gave {1} {2}.";

        public const string NotAttackable = "{0} cannot attack!";

        public const string NotHealable = "{0} cannot heal!";
    }
}
