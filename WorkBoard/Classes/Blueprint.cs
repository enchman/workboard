using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkBoard
{
    class Blueprint
    {
        public string Name;
        public Dictionary<Function.Type, int> Requirement = new Dictionary<Function.Type, int> { };
        private List<Function.Type> stations = new List<Function.Type> { };

        public Blueprint()
        {

        }

        public Blueprint(List<Function.Type> requires)
        {
            foreach(Function.Type job in requires)
            {
                if(!stations.Exists(x => x == job))
                {
                    // Adding non-exist item
                    stations.Add(job);
                    // Adding number of part
                    Requirement.Add(job, 1);
                }
                else
                {
                    Requirement[job]++;
                }
            }
        }

        public Blueprint(Dictionary<Function.Type, int> requires)
        {
            foreach(KeyValuePair<Function.Type, int> item in requires)
            {
                if(!stations.Exists(x => x == item.Key))
                {
                    stations.Add(item.Key);

                    Requirement.Add(item.Key, item.Value);
                }
                else
                {
                    Requirement[item.Key] += item.Value;
                }
            }
        }
    }
}
