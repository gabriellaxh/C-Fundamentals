namespace P01_HarvestingFields
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Text;

    public class HarvestingFieldsTest
    {
        public static void Main()
        {
            Type type = Type.GetType("P01_HarvestingFields.HarvestingFields");
            FieldInfo[] fields = type.GetFields(
                BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

            string accessModifier;
            var sb = new StringBuilder();

            IEnumerable<FieldInfo> fieldsToPrint = null;

            while ((accessModifier = Console.ReadLine()) != "HARVEST")
            {
                switch (accessModifier)
                {
                    case "protected":
                        fieldsToPrint = fields.Where(x => x.IsFamily);
                        break;

                    case "public":
                        fieldsToPrint = fields.Where(x => x.IsPublic);
                        break;

                    case "private":
                        fieldsToPrint = fields.Where(x => x.IsPrivate);
                        break;

                    case "all":
                        fieldsToPrint = fields;
                        break;
                }

                foreach (var field in fieldsToPrint)
                {
                    var access = field.Attributes.ToString().ToLower();

                    if (field.Attributes == FieldAttributes.Family)
                        access = "protected";

                    Console.WriteLine($"{access} {field.FieldType.Name} {field.Name}");
                }
            }
        }
    }
}
