using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS3BuildPlanner
{
    class Equipment
    {
        private static List<Item> equipment;
        private static Equipment instance;
        private Equipment()
        {
            equipment = new List<Item>();
        }
        public static Equipment getInstance()
        {
            if (instance == null)
            {
                instance = new Equipment();
            }
            return instance;

        }
        public void addItem(Item i)
        {
            equipment.Add(i);
        }
        public void removeItem(Item i)
        {
            if (equipment.Contains(i))
            {
                equipment.Remove(i);
            }
            else
            {
               throw new ItemNotFound();
            }
        }
    }
}
