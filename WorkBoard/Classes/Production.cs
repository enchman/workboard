﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace WorkBoard
{
    class Production
    {
        public enum Process { None, Drawing, Waiting, Active, Done}

        public Process Status { get; set; }

        public Function.Type Field;

        private Timer work;

        private List<Tool> machines = new List<Tool> { };

        private Dictionary<Function.Type, int> parts = new Dictionary<Function.Type, int> { };

        public Production()
        {

        }

        public Production(Blueprint schemic)
        {
            
        }

        public Production(List<Tool> machine)
        {

        }

        public void Start()
        {
            
        }

        public Item GetItem()
        {
            return new Item();
        }

        public List<Item> GetItems()
        {

        }
        
    }
}
