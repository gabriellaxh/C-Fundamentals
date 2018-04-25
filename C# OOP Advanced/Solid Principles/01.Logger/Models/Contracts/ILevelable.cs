using System;
using System.Collections.Generic;
using System.Text;

namespace Logger.App.Models.Contracts
{
    public interface ILevelable
    {
        MessageLevel Level { get; }
    }
}
