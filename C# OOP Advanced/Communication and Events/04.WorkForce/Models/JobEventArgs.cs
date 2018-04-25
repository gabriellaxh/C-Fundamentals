using System;
using System.Collections.Generic;
using System.Text;

namespace _04.WorkForce.Models
{
    public class JobEventArgs : EventArgs
    {
        public JobEventArgs(Job job)
        {
            this.Job = job;
        }

        public Job Job { get; set; }
    }
}
