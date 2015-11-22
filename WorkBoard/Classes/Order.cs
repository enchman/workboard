using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkBoard
{
    class Order
    {
        public int Id;
        public List<Item> Items = new List<Item> { };
        public DateTime OrderDate = DateTime.Now;
        public DateTime DeliverDate;

        public string Status()
        {
            return "Incomplete";
        }


    }
}
