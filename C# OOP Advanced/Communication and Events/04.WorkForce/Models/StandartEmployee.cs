using System;
using System.Collections.Generic;
using System.Text;

namespace _04.WorkForce
{
    public class StandartEmployee : IEmployee
    {
        private const int workHours = 40;

        public StandartEmployee(string name)
        {
            this.Name = name;
            this.WorkHoursPerWeek = workHours;
        }

        public string Name { get; set; }

        public int WorkHoursPerWeek { get; set; }
    }
}
