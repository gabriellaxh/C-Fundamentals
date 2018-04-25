using _04.WorkForce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.WorkForce.Controllers
{
    public class Engine
    {
        List<IEmployee> employees = new List<IEmployee>();
        List<Job> jobs = new List<Job>();

        public Engine()
        {
            this.employees = new List<IEmployee>();
            this.jobs = new List<Job>();
        }
        public void Run()
        {
            ExecuteCommands();
        }

        private void ExecuteCommands()
        {
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                var info = command.Split();

                switch (info[0])
                {
                    case "StandardEmployee":
                        var newEmp1 = new StandartEmployee(info[1]);
                        employees.Add(newEmp1);
                        break;

                    case "PartTimeEmployee":
                        var newEmp2 = new PartTimeEmployee(info[1]);
                        employees.Add(newEmp2);
                        break;

                    case "Job":
                        var emp = this.employees.FirstOrDefault(x => x.Name == info[3]);
                        var newJob = new Job(info[1], int.Parse(info[2]), emp);
                        newJob.Update += newJob.OnUpdate;
                        this.jobs.Add(newJob);
                        break;

                    case "Pass":
                        foreach (var job in jobs.ToArray())
                        {
                            job.OnUpdate(job,new JobEventArgs(job));
                            if (job.RequiredWorkHours <= 0)
                            {
                                jobs.Remove(job);
                                continue;
                            }
                        }
                        break;

                    case "Status":
                        foreach (var job in jobs)
                        {
                            Console.WriteLine(job.ToString());
                        }
                        break;
                }
            }
        }
    }
}
