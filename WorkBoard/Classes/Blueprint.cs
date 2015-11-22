using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkBoard
{
    class Blueprint
    {
        public List<Function.Type> Requirement = new List<Function.Type> { };
        public Dictionary<Function.Type, int> NumberOfPart = new Dictionary<Function.Type, int> { };

        public Blueprint()
        {

        }

        public Blueprint(List<Function.Type> requires)
        {
            this.Requirement = requires;
        }

    }
}
