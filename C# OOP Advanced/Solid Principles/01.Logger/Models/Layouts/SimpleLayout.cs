using Logger.App.Layouts;
using Logger.App.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Logger.App.Models.Layouts
{
    public class SimpleLayout : ILayout
    {
        const string DateFormat = "M/d/yyyy h:mm:ss tt";
        public string Format(IMessage error)
        {
            return $"{error.DateTime.ToString(DateFormat,CultureInfo.InvariantCulture)} - {error.Level} - {error.Text}";
        }
    }
}
 