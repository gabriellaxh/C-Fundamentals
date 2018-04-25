using Logger.App.Layouts;
using Logger.App.Models.Contracts;
using System;
using System.Globalization;

namespace Logger.Models.Layouts
{
    public class XmlLayout : ILayout
    {
        const string DateFormat = "HH:mm:ss dd-MMM-yyyy";
        private string Formatted =
            "<log>" + Environment.NewLine +
                "\t<date>{0}</date>" + Environment.NewLine +
                "\t<level>{1}</level>" + Environment.NewLine +
                "\t<message>{2}</message>" + Environment.NewLine +
            "</log>";


        public string Format(IMessage message)
        {
            string date = message.DateTime.ToString(DateFormat, CultureInfo.InvariantCulture);
            string formattedMsg = string.Format(Formatted, date, message.Level.ToString(), message.Text);
            return formattedMsg;
        }
    }
}
