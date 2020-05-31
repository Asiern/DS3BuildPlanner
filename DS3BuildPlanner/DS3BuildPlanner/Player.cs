using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS3BuildPlanner
{
    class Player
    {
        private string startingClass;
        private int level;
        private int souls;

        //BASE POWER
        private int hp;
        private int fp;
        private int stamina;
        private float equipLoad;
        private float poise;
        private int itemDiscovery;

        //ATTACK POWER
        private int rWeapon1;
        private int rWeapon2;
        private int rWeapon3;
        private int lWeapon1;
        private int lWeapon2;
        private int lWeapon3;

        //DEFENSE
        private int physicalDefense;
        private int magicDefense;
        private int fireDefense;
        private int lightningDefense;
        private int darkDefense;

        //RESISTANCES
        private int bleedResistance;
        private int poisonResistance;
        private int frostResistance;
        private int curseResistance;

        //SLOTS
        private int attunementSlots;

        //ATTRIBUTES
        private int vigor;
        private int attunement;
        private int endurance;
        private int vitality;
        private int strenght;
        private int dexterity;
        private int intelligence;
        private int faith;
        private int luck;


        public Player()
        {

        }
    }
}
