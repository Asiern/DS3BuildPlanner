using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS3BuildPlanner
{
    class Armor
    {
        private String name;
        private float physicalAbsortion;
        private float magicAbsortion;
        private float fireAbsortion;
        private float lightningAbsortion;
        private float darkAbsortion;
        private int bleedResistance;
        private int poisonResistance;
        private int frostResistance;
        private int curseResistance;
        private float poise;
        private float weight;
        private float poiseWeightRatio;

        public Armor()
        {

        }
        public Armor(string name, float physicalAbsortion, float magicAbsortion, float fireAbsortion, float lightningAbsortion, float darkAbsortion, int bleedResistance, int poisonResistance, int frostResistance, int curseResistance, float poise, float weight, float poiseWeightRatio)
        {
            this.name = name;
            this.physicalAbsortion = physicalAbsortion;
            this.magicAbsortion = magicAbsortion;
            this.fireAbsortion = fireAbsortion;
            this.lightningAbsortion = lightningAbsortion;
            this.darkAbsortion = darkAbsortion;
            this.bleedResistance = bleedResistance;
            this.poisonResistance = poisonResistance;
            this.frostResistance = frostResistance;
            this.curseResistance = curseResistance;
            this.poise = poise;
            this.weight = weight;
            this.poiseWeightRatio = poiseWeightRatio;
        }

        //Getter & Setters
        public String Name { get { return name; } set { name = value; } }
        public float PhysicalAbsortion { get { return physicalAbsortion; } set { this.physicalAbsortion = value; } }
        public float MagicAbsortion { get { return this.magicAbsortion; } set { this.magicAbsortion = value; } }
        public float FireAbsortion { get { return fireAbsortion; } set { fireAbsortion = value; } }
        public float LightningAbsortion { get { return lightningAbsortion; } set { lightningAbsortion = value; } }
        public float DarkAbsortion { get { return darkAbsortion; } set { darkAbsortion = value; } }
        public int BleedResistance { get { return bleedResistance; } set { bleedResistance = value; } }
        public int PoisonResistance { get { return poisonResistance; } set { poisonResistance = value; } }
        public int FrostResistance { get { return frostResistance; } set { frostResistance = value; } }
        public int CurseResistance { get { return curseResistance; } set { curseResistance = value; } }
        public float Poise { get { return poise; } set { poise = value; } }
        public float Weight { get { return weight; } set { weight = value; } }
        public float PoiseWeightRatio { get { return poiseWeightRatio; } set { poiseWeightRatio = value; } }


    }
}
