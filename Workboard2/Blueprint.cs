using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workboard2
{
    class Blueprint
    {
        public enum Instruction { Punching = 4, Welding = 10, Bending = 6, LaserCutter = 10, Milling = 10, Shears = 6, Assembling = 10 }
        public List<Instruction> Instructions = new List<Instruction> { };
    }
}
