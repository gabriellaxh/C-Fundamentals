namespace P02_BlackBoxInteger
{
    using System;
    using System.Linq;
    using System.Reflection;

    public class BlackBoxIntegerTests
    {
        public static void Main()
        {
            Type type = Type.GetType("P02_BlackBoxInteger.BlackBoxInteger");

            var innerValue = type.GetField("innerValue", BindingFlags.Instance | BindingFlags.NonPublic);
            var instance = Activator.CreateInstance(type,true);

            string command;
            while((command = Console.ReadLine()) != "END")
            {
                var input = command.Split(new[] { '_' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                var methodName = input[0];

                MethodInfo[] methods = type.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
                var method = methods.FirstOrDefault(x => x.Name == methodName);
                method.Invoke(instance, new object[] { int.Parse(input[1]) });
                Console.WriteLine(innerValue.GetValue(instance));
            }
        }
    }
}
