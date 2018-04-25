using System;
using System.Collections.Generic;
using System.Text;

namespace _04.WorkForce
{
    public class PartTimeEmployee : IEmployee
    {
        private const int workHours = 20;

        public PartTimeEmployee(string name)
        {
            this.Name = name;
            this.WorkHoursPerWeek = workHours;
        }

        public string Name { get; set; }

        public int WorkHoursPerWeek { get; set; }
    }
}
