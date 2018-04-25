using Logger.App.Layouts;
using Logger.App.Models.Contracts;
using System;

namespace Logger.App.Models
{
    public class ConsoleAppender : IAppender
    {
        public ILayout Layout { get; }

        public MessageLevel Level { get; }

        public int MessagesAppended { get; private set; }


        public ConsoleAppender(ILayout layout, MessageLevel level)
        {
            this.Layout = layout;
            this.Level = level;
            this.MessagesAppended = 0;
        }
        
        public void Append(IMessage message)
        {
            Console.WriteLine(this.Layout.Format(message));
            this.MessagesAppended++;
        }

        public override string ToString()
        {
            string result = $"Appender Type: {this.GetType().Name}, Layout type: {this.Layout.GetType().Name}, Report Level {this.Level}, Message appended: {this.MessagesAppended}";
            return result;
        }
    }
}
