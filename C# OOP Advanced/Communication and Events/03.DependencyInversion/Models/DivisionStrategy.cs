using _03.DependencyInversion.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _03.DependencyInversion
{
    public class DivisionStrategy : IStrategy
    {
        public int Calculate(int firstOperand, int secondOperand)
        {
            return firstOperand / secondOperand;
        }
    }
}
