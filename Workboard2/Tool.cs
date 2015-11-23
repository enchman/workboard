using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Workboard2
{
    class Tool
    {
        public enum Function { Punching = 4, Welding = 10, Bending = 6, LaserCutter = 10, Milling = 10, Shears = 6, Assembling = 10 }

        public Function Process;
        public int WorkCycle
        {
            get
            {
                return (int)Process;
            }
        }

        private Timer work;

        public void Start(Joblist job)
        {
            if(work == null)
            {
                work = new Timer(WorkCycle);
                work.Elapsed += UpdateStatus;
            }
        }

        private void UpdateStatus(object obj, ElapsedEventArgs e)
        {

        }
    }
}
