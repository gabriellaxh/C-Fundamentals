using DungeonsAndCodeWizards.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace DungeonsAndCodeWizards.Factories
{
    public class ItemFactory
    {
        public Item CreateItem(string itemType)
        {
            Type type = Assembly.GetExecutingAssembly()
                                .GetTypes()
                                .FirstOrDefault(x => x.Name == itemType);

            if (type == null)
                throw new ArgumentException(string.Format(Constants.InvalidItemName, itemType));

            Item instance = (Item)Activator.CreateInstance(type);
            return instance;
        }
    }
}
