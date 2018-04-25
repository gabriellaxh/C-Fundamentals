using System;

namespace Logger.App.Models.Contracts
{
    public interface IMessage : ILevelable
    {
        DateTime DateTime { get; }

        string Text { get; }
    }
}