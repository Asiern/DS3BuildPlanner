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
        private float PhysicalAbsortion ;
        private float MagicAbsortion;
        private float FireAbsortion;
        private float LightningAbsortion;
        private float DarkAbsortion;
        private int BleedResistance;
        private int PoisonResistance;
        private int FrostResistance;
        private int CurseResistance;
        private float Poise;
        private float Weight;
        private float PoiseWeightRatio;

        public Armor(string name, float physicalAbsortion, float magicAbsortion, float fireAbsortion, float lightningAbsortion, float darkAbsortion, int bleedResistance, int poisonResistance, int frostResistance, int curseResistance, float poise, float weight, float poiseWeightRatio)
        {
            this.name = name;
            PhysicalAbsortion = physicalAbsortion;
            MagicAbsortion = magicAbsortion;
            FireAbsortion = fireAbsortion;
            LightningAbsortion = lightningAbsortion;
            DarkAbsortion = darkAbsortion;
            BleedResistance = bleedResistance;
            PoisonResistance = poisonResistance;
            FrostResistance = frostResistance;
            CurseResistance = curseResistance;
            Poise = poise;
            Weight = weight;
            PoiseWeightRatio = poiseWeightRatio;
        }
    }
}
