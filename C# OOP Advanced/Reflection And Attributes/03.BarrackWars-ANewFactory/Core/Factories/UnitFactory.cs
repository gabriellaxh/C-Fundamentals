namespace _03BarracksFactory.Core.Factories
{
    using System;
    using System.Linq;
    using Contracts;

    public class UnitFactory : IUnitFactory
    {
        public IUnit CreateUnit(string unitType)
        {
            //Assembly assembly = Assembly.GetExecutingAssembly();
            Type type = Type.GetType("_03BarracksFactory.Models.Units." + unitType);
            if (type == null)
            {
                throw new ArgumentException("Invalid Unit Type!");
            }
            if (!type.GetInterfaces().Any(x => x == typeof(IUnit)))
            {
                throw new ArgumentException($"{unitType} is Not a Unit Type!");
            }
            var instance = (IUnit)Activator.CreateInstance(type);

            return instance;
        }
    }
}
