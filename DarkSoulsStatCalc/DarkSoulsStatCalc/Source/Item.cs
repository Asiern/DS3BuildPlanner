using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Item
{
    public Item(string name, float weight)
    {
        Name = name;
        Weight = weight;
    }

    public string Name { get; private set; }
    public float Weight { get; private set; }
}