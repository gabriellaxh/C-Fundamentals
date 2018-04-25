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

    public string AnalyzeAcessModifiers(string className)
    {
        var sb = new StringBuilder();

        var type = Type.GetType(className);
        var fields = type.GetFields();

        foreach (var field in fields)
        {
            sb.AppendLine($"{field.Name} must be private!");
        }

        var properties = type.GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

        foreach (var prop in properties)
        {
            if (prop.GetMethod?.IsPrivate == true)
                sb.AppendLine($"{prop.GetMethod.Name} have to be public!");
        }
        foreach (var prop in properties)
        {
            if (prop.SetMethod?.IsPublic == true)
                sb.AppendLine($"{prop.SetMethod.Name} have to be private!");
        }

        return sb.ToString().Trim();
    }
}

