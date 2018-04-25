using System.Collections.Generic;

namespace Logger.App.Models.Contracts
{
    public interface ILogger
    {
        IReadOnlyCollection<IAppender> Appenders { get; }

        void Log(IMessage message);
    }
}
