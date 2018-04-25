using DungeonsAndCodeWizards.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace DungeonsAndCodeWizards.Factories
{
    public class CharacterFactory
    {
        public Character CreateCharacter(string faction, string characterType, string name)
        {


            if (faction != "CSharp" && faction != "Java")
                throw new ArgumentException(string.Format(Constants.InvalidFaction, faction));

            Faction actualFaction = (Faction)Enum.Parse(typeof(Faction), faction);

            if (characterType == null)
                throw new ArgumentException(string.Format(Constants.InvalidCharacterType, characterType));

            Type type = Assembly.GetExecutingAssembly()
                                .GetTypes()
                                .FirstOrDefault(x => x.Name == characterType);
            if (type == null)
                throw new ArgumentException(string.Format(Constants.InvalidCharacterType, characterType));

            Character instance = (Character)Activator.CreateInstance(type, name, actualFaction);
            return instance;
        }
    }
}
