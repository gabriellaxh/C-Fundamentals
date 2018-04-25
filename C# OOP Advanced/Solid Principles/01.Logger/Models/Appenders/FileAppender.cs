using Logger.App.Layouts;
using Logger.App.Models.Contracts;

namespace Logger.App.Models.Appenders
{
    public class FileAppender : IAppender
    {
        public ILayout Layout { get; }
        public MessageLevel Level { get; }
        private ILogFile logFile { get; }
        public int MessagesAppended { get; private set; }

        public FileAppender(ILayout layout, MessageLevel level, ILogFile logFile)
        {
            this.Layout = layout;
            this.Level = level;
            this.logFile = logFile;
            this.MessagesAppended = 0;
        }

        public void Append(IMessage message)
        {
            this.logFile.Write(this.Layout.Format(message));
            this.MessagesAppended++;
        }

        public override string ToString()
        {
            string result = $"Appender Type: {this.GetType().Name}, Layout type: {this.Layout.GetType().Name}, Report Level {this.Level}," +
                $"Message appended: {this.MessagesAppended}, File size: {this.logFile.Size}";
            return result;
        }
    }
}
