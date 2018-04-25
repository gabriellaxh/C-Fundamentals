using Logger.App.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logger.App.Layouts
{
    public interface ILayout
    {
        string Format(IMessage error);
    }
}
