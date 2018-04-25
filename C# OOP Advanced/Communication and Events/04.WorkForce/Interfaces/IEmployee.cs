using System;
using System.Collections.Generic;
using System.Text;

namespace _04.WorkForce
{
    public interface IEmployee
    {
        string Name { get; set; }
        int WorkHoursPerWeek { get; set; }
    }
}
