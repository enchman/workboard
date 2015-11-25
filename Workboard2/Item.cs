using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workboard2
{
    class Item
    {
        public string Name;
        public readonly int Id;
        public Makeup.DefaultMakeup Type = Makeup.DefaultMakeup.Normal;

        private static int currentId = 1;

        public Item()
        {
            this.Id = currentId;
            currentId++;
        }

        public Item(string name)
        {
            this.Name = name;
            this.Id = currentId;
            currentId++;
        }

        public Item(int id)
        {
            this.Id = id;
        }

        public Item(Makeup.DefaultMakeup type)
        {
            this.Type = type;
            this.Id = currentId;
            currentId++;
        }

        public Item(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public Item(int id, Makeup.DefaultMakeup type)
        {
            this.Id = id;
            this.Type = type;
        }

        public Item(string name, Makeup.DefaultMakeup type)
        {
            this.Name = name;
            this.Type = type;
            this.Id = currentId;
            currentId++;
        }

        public Item(int id, string name, Makeup.DefaultMakeup type)
        {
            this.Id = id;
            this.Name = name;
            this.Type = type;
        }

    }
}
