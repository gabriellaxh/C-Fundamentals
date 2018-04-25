using Logger.App.Models;
using Logger.App.Models.Appenders;
using Logger.App.Models.Contracts;
using System;

namespace Logger.Models.Factories
{
    public class AppenderFactory
    {
        const string DefaultFileName = "logFile{0}.txt";

        private LayoutFactory layoutFactory;
        private int fileNumber;

        public AppenderFactory(LayoutFactory layoutFactory)
        {
            this.layoutFactory = layoutFactory;
            this.fileNumber = 0;
        }

        public IAppender CreateAppender(string appenderType, string layoutType, string level)
        {
            var layout = this.layoutFactory.CreateLayout(layoutType);
            var messageLevel = this.ValidateError(level);

            IAppender appender = null;
            switch (appenderType)
            {
                case "ConsoleAppender":
                    appender = new ConsoleAppender(layout, messageLevel);
                    break;
                case "FileAppender":
                    ILogFile logFile = new LogFile(string.Format(DefaultFileName, this.fileNumber));
                    appender = new FileAppender(layout, messageLevel, logFile);
                    break;
                default:
                    throw new ArgumentException("Invalid appender type!");
            }
            return appender;
        }

        private MessageLevel ValidateError(string level)
        {
            try
            {
                var levelObj = Enum.Parse(typeof(MessageLevel), level);
                return (MessageLevel)levelObj;
            }
            catch(ArgumentException ex)
            {
                throw new ArgumentException("Invalid MessageLevel Type!");
            }
        }
    }
}
