using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS3BuildPlanner
{
    class Item
    {
        private String name;
        private float weight;

        //Item Builder
        public Item(String name, float weight)
        {
            this.name = name;
            this.weight = weight;
        }

        //Getters & Setters
        public String Name {
            get { return name; }
            set { name = value; }
        }
        public float Weight { 
            get { return weight; }
            set { weight = value; } 
        }

        //Equals method override
        public override bool Equals(Object obj)
        {
            var item = obj as Item;

            if (item == null)
            {
                return false;
            }

            return this.name.Equals(item.name);
        }

        public override int GetHashCode()
        {
            return this.name.GetHashCode();
        }
    }
}
