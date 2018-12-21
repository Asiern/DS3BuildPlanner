using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

public static class CSV
{
    public static List<Item> Read(string path)
    {
        List<Item> items = new List<Item>();

        using (StreamReader reader = new StreamReader(path)) // Used to read the file data
        {
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();

                // Skips the first line which has no information
                if (line.Contains("Name,Weight"))
                    continue;

                // Split the line by the comma so that both columns are separated
                string[] values = line.Split(',');

                // set the properties of the item and parse the value string to float
                string name = values[0];
                float weight = float.Parse(values[1], System.Globalization.CultureInfo.InvariantCulture);

                items.Add(new Item(name, weight));
            }
        }

        return items;
    }
}