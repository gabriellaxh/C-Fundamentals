using System;
using System.Collections.Generic;
using System.Text;

[AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, AllowMultiple = true)]
public class SoftUniAttribute : Attribute
{
    public string Name { get; set; }

    public SoftUniAttribute(string name)
    {
        this.Name = name;
    }
}

