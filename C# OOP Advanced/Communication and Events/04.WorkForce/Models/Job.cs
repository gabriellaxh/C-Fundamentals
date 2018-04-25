using System;
using System.Collections.Generic;
using System.Text;

namespace _04.WorkForce.Models
{
    public delegate void JobDoneEventHandler(object sender, JobEventArgs args);

    public class Job
    {
        public event JobDoneEventHandler Update;

        private string name;
        private int requiredWorkHours;
        private IEmployee employee;

        public Job(string name, int requiredWorkHours, IEmployee employee)
        {
            this.Name = name;
            this.RequiredWorkHours = requiredWorkHours;
            this.Employee = employee;
        }

        public string Name
        {
            get => this.name;
            set => this.name = value;
        }

        public int RequiredWorkHours
        {
            get => this.requiredWorkHours;
            set => this.requiredWorkHours = value;
        }

        public IEmployee Employee
        {
            get => this.employee;
            set => this.employee = value;
        }

        public void OnUpdate(object sender, JobEventArgs args)
        {
            this.requiredWorkHours -= this.employee.WorkHoursPerWeek;

            if (this.requiredWorkHours <= 0)
            {
                Console.WriteLine($"Job {this.Name} done!");
            }
            
        }
        
        public override string ToString()
        {
            return $"Job: {this.Name} Hours Remaining: {this.RequiredWorkHours}";
        }
    }
}
