using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workboard2
{
    class Order
    {
        public Customer Owner;
        public Dictionary<Item, int> Items = new Dictionary<Item, int> { };
        public DateTime OrderDate;
        public DateTime DeliverDate = new DateTime(1,1,1);
    }
}
