using System;
using System.Collections.Generic;
using System.Text;

namespace _03.DependencyInversion.Interfaces
{
    interface IStrategy
    {
        int Calculate(int firstOperand, int secondOperand);
    }
}
