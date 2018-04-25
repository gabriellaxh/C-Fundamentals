using Logger.App.Models.Contracts;
using System.Collections.Generic;

namespace Logger.App.Models
{
    public class MyLogger : ILogger
    {
        IEnumerable<IAppender> appenders;

        public MyLogger(IEnumerable<IAppender> appenders)
        {
            this.appenders = appenders;
        }

        public IReadOnlyCollection<IAppender> Appenders => (IReadOnlyCollection<IAppender>)this.appenders;

        public void Log(IMessage message)
        {
            foreach (IAppender appender in appenders)
            {
                if (message.Level >= appender.Level)
                    appender.Append(message);
            }
        }
    }
}
