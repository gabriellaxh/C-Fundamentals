using Logger.App.Layouts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logger.App.Models.Contracts
{
    public interface IAppender
    {
        ILayout Layout { get; }

        MessageLevel Level { get; }

        void Append(IMessage message);
    }
}
