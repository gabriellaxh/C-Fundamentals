using Logger.App.Models;
using Logger.App.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Logger.Models.Factories
{
    public class MessageFactory
    {
        const string DateFormat = "M/d/yyyy h:mm:ss tt";
        public IMessage CreateMessage(string dateTime,string messageLevel,string message)
        {
            DateTime dateTimeParsed = DateTime.ParseExact(dateTime, DateFormat, CultureInfo.InvariantCulture);
            MessageLevel level = ValidateError(messageLevel);
            IMessage newMessage = new Message(dateTimeParsed, level, message);

            return newMessage;
        }

        private MessageLevel ValidateError(string level)
        {
            try
            {
                var levelObj = Enum.Parse(typeof(MessageLevel), level);
                return (MessageLevel)levelObj;
            }
            catch (ArgumentException ex)
            {
                throw new ArgumentException("Invalid MessageLevel Type!");
            }
        }
    }
}
