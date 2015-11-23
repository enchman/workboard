using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workboard2
{
    class Joblist
    {
        const int START_HOUR = 9;
        const int START_MINUTE = 30;
        const int END_HOUR = 9;
        const int END_MINUTE = 30;

        public enum WorkDay { Sunday, Monday, Thirsday, Wednessday, Thursday, Friday, Saturday }

        public Dictionary<Tool, Employee> Work = new Dictionary<Tool, Employee> { };

        private DateTime startTime;
        private DateTime endTime;

        public Joblist()
        {
            foreach(KeyValuePair<Tool, Employee> item in Work)
            {
                
            }
        }

    }
}
