using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workboard2
{
    class WorkController
    {
        public static List<Makeup> Platforms = new List<Makeup> { };
        public static List<Order> Orders = new List<Order> { };

        public WorkController()
        {
            
        }

        public void ReadOrders()
        {


            foreach(Order item in Orders)
            {
                
            }
        }

        public void doWorkRutine()
        {

        }


        private bool OutofOrder(DateTime input)
        {
            // Check none delivery date
            int deliver = DateTime.Compare(input, new DateTime(1, 1, 1));

            // Not yet delivered
            if(deliver == 0)
            {
                return true;
            }
            // Check if item is already delivered
            else
            {
                deliver = DateTime.Compare(input, DateTime.Now);
                return deliver > 0;
            }
        }
    }
}
