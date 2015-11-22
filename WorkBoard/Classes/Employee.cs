using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkBoard
{
    class Employee
    {
        public enum Position { Administration, MachineSpecialist};

        public int Id { get; set; }
        public string Name { get; set; }

        public List<Function.Type> Specialist = new List<Function.Type> { };

        

    }
}
