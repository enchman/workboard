using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Workboard2
{
    class Machine
    {
        public enum Progress { Working, Done }

        public Progress Status = Progress.Working;

        public readonly Blueprint.Instruction Function;

        public Employee Worker { get; set; }

        private int timing
        {
            get
            {
                return (int)Function;
            }
        }

        public Machine(Blueprint.Instruction type)
        {
            this.Function = type;
        }
    }
}
