using System;
using System.Linq;
using System.Reflection;
using System.Text;

    public class Spy
    {
        public string StealFieldInfo(string classToInvestigate, params string[] fieldsToInvestigate)
        {
            Type type = Type.GetType(classToInvestigate);
            FieldInfo[] fields = type.GetFields(
                BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);

            var sb = new StringBuilder();

            var instance = Activator.CreateInstance(type);

            sb.AppendLine($"Class under investigation: {classToInvestigate}");
            foreach (var field in fields.Where(x => fieldsToInvestigate.Contains(x.Name)))
            {
                sb.AppendLine($"{field.Name} = {field.GetValue(instance)}");
            }

            return sb.ToString().Trim();
        }
    }

