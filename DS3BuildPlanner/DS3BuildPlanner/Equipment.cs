using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS3BuildPlanner
{
    class Equipment
    {
        private static List<Armor> Chest;
        private static List<Ring> Rings;

        private static Equipment instance;
        private Equipment()
        {
            Chest = new List<Armor>();
            loadArmor();
            Rings = new List<Ring>();
        }
        public static Equipment getInstance()
        {
            if (instance == null)
            {
                instance = new Equipment();
            }
            return instance;

        }
        public void addArmor(Armor a)
        {

            Chest.Add(a);
        }
        public void removeArmor(Armor a)
        {
            if (Chest.Contains(a))
            {
                Chest.Remove(a);
            }
            else
            {
               throw new ItemNotFound();
            }
        }


        public void loadArmor()
        {
            string path = System.IO.Path.GetFullPath("chest.csv");

            using (StreamReader reader = new StreamReader(path)) // Used to read file data
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();

                    // Split the line by the tab so that both columns are separated
                    string[] values = line.Split(',');

                    // set the properties of the item and parse the value string to float
                    string name = values[0];
                    float physicalAbsortion = float.Parse(values[1], System.Globalization.CultureInfo.InvariantCulture);
                    float ST = float.Parse(values[2], System.Globalization.CultureInfo.InvariantCulture);
                    float SL = float.Parse(values[3], System.Globalization.CultureInfo.InvariantCulture);
                    float TH = float.Parse(values[4], System.Globalization.CultureInfo.InvariantCulture);
                    float magicAbsortion = float.Parse(values[5], System.Globalization.CultureInfo.InvariantCulture);
                    float fireAbsortion = float.Parse(values[6], System.Globalization.CultureInfo.InvariantCulture);
                    float lightningAbsortion = float.Parse(values[7], System.Globalization.CultureInfo.InvariantCulture);
                    float darkAbsortion = float.Parse(values[8], System.Globalization.CultureInfo.InvariantCulture);
                    int bleedResistance = int.Parse(values[9], System.Globalization.CultureInfo.InvariantCulture);
                    int poisonResistance = int.Parse(values[10], System.Globalization.CultureInfo.InvariantCulture);
                    int frostResistance = int.Parse(values[11], System.Globalization.CultureInfo.InvariantCulture);
                    int curseResistance = int.Parse(values[12], System.Globalization.CultureInfo.InvariantCulture);
                    float poise = float.Parse(values[13], System.Globalization.CultureInfo.InvariantCulture);
                    float weight = float.Parse(values[14], System.Globalization.CultureInfo.InvariantCulture);
                    float poiseWeightRatio = float.Parse(values[15], System.Globalization.CultureInfo.InvariantCulture);

                    //Weapon
                    Armor chest = new Armor(name, physicalAbsortion, magicAbsortion, fireAbsortion, lightningAbsortion, darkAbsortion, bleedResistance, poisonResistance, 
                        frostResistance, curseResistance, poise, weight, poiseWeightRatio);
                    Chest.Add(chest);
                }
            }
        }
    }
}
