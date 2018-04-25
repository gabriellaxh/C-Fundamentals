using _03BarracksFactory.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace _03BarracksFactory.Core
{
    public class CommandInterpreter : ICommandInterpreter
    {
        private IRepository repository;
        private IUnitFactory unitFactory;

        public CommandInterpreter(IRepository repository, IUnitFactory unitFactory)
        {
            this.repository = repository;
            this.unitFactory = unitFactory;
        }

        public IExecutable InterpretCommand(string[] data, string commandName)
        {
            Assembly assembly = Assembly.GetCallingAssembly();
            var type = assembly.GetTypes().FirstOrDefault(x => x.Name.ToLower() == commandName + "command");

            if (type == null)
                throw new ArgumentException("Invalid Command!");

            if (!typeof(IExecutable).IsAssignableFrom(type))
                throw new ArgumentException($"{commandName} Is Not A Command!");

            object[] constructorArgs = new object[] { data, this.repository, this.unitFactory };
            IExecutable instance = (IExecutable)Activator.CreateInstance(type, constructorArgs);

            return instance;
        }
    }
}
