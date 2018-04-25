using Logger.App.Models.Contracts;
using System;

namespace Logger.App.Models
{
    public class Message : IMessage
    {
        public DateTime DateTime { get; }

        public MessageLevel Level { get; }

        public string Text { get; }

        public Message(DateTime dateTime, MessageLevel level, string text)
        {
            this.DateTime = dateTime;
            this.Level = level;
            this.Text = text;
        }
    }
}
