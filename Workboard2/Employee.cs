﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workboard2
{
    class Employee
    {
        public int DailyWorkInMinute = 0;
        public int TotalWorkingTime = 0;

        public string Name { get; set; }
        
        private Joblist Job { get; set; }

        public Employee(string name)
        {
            this.Name = name;
        }


        public void AddTask(Joblist job)
        {
            this.Job = job;
        }

    }
}
