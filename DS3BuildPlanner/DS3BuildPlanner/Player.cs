using MaterialSkin.Controls;
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

        //CLASS ATTRIBUTES
        private int baselevel;
        private int basevigor;
        private int baseattunement;
        private int baseendurance;
        private int basevitality;
        private int basestrenght;
        private int basedexterity;
        private int baseintelligence;
        private int basefaith;
        private int baseluck;

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

        //GETTERS
        public int getbaseVigor()
        {
            return this.basevigor;
        }
        public int getbaseAttunement()
        {
            return this.baseattunement;
        }
        public int getbaseEndurance()
        {
            return this.baseendurance;
        }
        public int getbaseVitality()
        {
            return this.basevitality;
        }
        public int getbaseStrenght()
        {
            return this.basestrenght;
        }
        public int getbaseDexterity()
        {
            return this.basedexterity;
        }
        public int getbaseIntelligence()
        {
            return this.baseintelligence;
        }
        public int getbaseFaith()
        {
            return this.basefaith;
        }
        public int getbaseLuck()
        {
            return this.baseluck;
        }
        public int getbaseLevel()
        {
            return this.baselevel;
        }
        public int getVigor()
        {
            return this.vigor;
        }
        public int getAttunement()
        {
            return this.attunement;
        }
        public int getEndurance()
        {
            return this.endurance;
        }
        public int getVitality()
        {
            return this.vitality;
        }
        public int getStrenght()
        {
            return this.strenght;
        }
        public int getDexterity()
        {
            return this.dexterity;
        }
        public int getIntelligence()
        {
            return this.intelligence;
        }
        public int getFaith()
        {
            return this.faith;
        }
        public int getLuck()
        {
            return this.luck;
        }
        public int getLevel()
        {
            return this.level;
        }
        public int getFP()
        {
            return this.fp;
        }
        public int getHP()
        {
            return this.hp;
        }

        //SETTERS

        public void setVigor(int v)
        {
            this.vigor = v;       
        }
        public void setAttunement(int a)
        {
            this.attunement = a;
        }
        public void setEndurance(int e)
        {
            this.endurance = e;
        }
        public void setVitality(int v)
        {
            this.vitality = v;
        }
        public void setStrenght(int s)
        {
            this.strenght = s;
        }
        public void setDexterity(int d)
        {
            this.dexterity = d;
        }
        public void setIntelligence(int i)
        {
            this.intelligence = i;
        }
        public void setFaith(int f)
        {
            this.faith = f;
        }
        public void setLuck(int l)
        {
            this.luck = l;
        }
        public void setLevel(int l)
        {
            this.level = l;
        }
        public void setFP(int FP)
        {
            this.fp = FP;
        }
        public void setHP(int HP)
        {
            this.hp = HP;
        }

        public Player(string startingClass, int level, int souls, int hp, int fp, int stamina, float equipLoad, float poise, int itemDiscovery, int rWeapon1, int rWeapon2, int rWeapon3, int lWeapon1, int lWeapon2, int lWeapon3, int physicalDefense, int magicDefense, int fireDefense, int lightningDefense, int darkDefense, int bleedResistance, int poisonResistance, int frostResistance, int curseResistance, int attunementSlots, int vigor, int attunement, int endurance, int vitality, int strenght, int dexterity, int intelligence, int faith, int luck)
        {
            this.startingClass = startingClass;
            this.level = level;
            this.souls = souls;
            this.hp = hp;
            this.fp = fp;
            this.stamina = stamina;
            this.equipLoad = equipLoad;
            this.poise = poise;
            this.itemDiscovery = itemDiscovery;
            this.rWeapon1 = rWeapon1;
            this.rWeapon2 = rWeapon2;
            this.rWeapon3 = rWeapon3;
            this.lWeapon1 = lWeapon1;
            this.lWeapon2 = lWeapon2;
            this.lWeapon3 = lWeapon3;
            this.physicalDefense = physicalDefense;
            this.magicDefense = magicDefense;
            this.fireDefense = fireDefense;
            this.lightningDefense = lightningDefense;
            this.darkDefense = darkDefense;
            this.bleedResistance = bleedResistance;
            this.poisonResistance = poisonResistance;
            this.frostResistance = frostResistance;
            this.curseResistance = curseResistance;
            this.attunementSlots = attunementSlots;
            this.vigor = vigor;
            this.attunement = attunement;
            this.endurance = endurance;
            this.vitality = vitality;
            this.strenght = strenght;
            this.dexterity = dexterity;
            this.intelligence = intelligence;
            this.faith = faith;
            this.luck = luck;
        }

        public Player()
        {

        }

        //LOAD STARTING CLASS STATS
        public void setupPlayer(String startingClass)
        {
            if (this.startingClass != startingClass) this.startingClass = startingClass;


            switch (startingClass)
            {
                case "Knight":
                    this.level = 9;
                    this.vigor = 12;
                    this.attunement = 10;
                    this.endurance = 11;
                    this.vitality = 15;
                    this.strenght = 13;
                    this.dexterity = 12;
                    this.intelligence = 9;
                    this.faith = 9;
                    this.luck = 7;
                    this.baselevel = 9;
                    this.basevigor = 12;
                    this.baseattunement = 10;
                    this.baseendurance = 11;
                    this.basevitality = 15;
                    this.basestrenght = 13;
                    this.basedexterity = 12;
                    this.baseintelligence = 9;
                    this.basefaith = 9;
                    this.baseluck = 7;

                    break;
                case "Mercenary":
                    this.level = 8;
                    this.vigor = 11;
                    this.attunement = 12;
                    this.endurance = 11;
                    this.vitality = 10;
                    this.strenght = 10;
                    this.dexterity = 16;
                    this.intelligence = 10;
                    this.faith = 8;
                    this.luck = 9;
                    this.baselevel = 8;
                    this.basevigor = 11;
                    this.baseattunement = 12;
                    this.baseendurance = 11;
                    this.basevitality = 10;
                    this.basestrenght = 10;
                    this.basedexterity = 16;
                    this.baseintelligence = 10;
                    this.basefaith = 8;
                    this.baseluck = 9;
                    break;
                case "Warrior":
                    this.level = 7;
                    this.vigor = 14;
                    this.attunement = 6;
                    this.endurance = 12;
                    this.vitality = 11;
                    this.strenght = 16;
                    this.dexterity = 9;
                    this.intelligence = 8;
                    this.faith = 9;
                    this.luck = 11;
                    this.baselevel = 7;
                    this.basevigor = 14;
                    this.baseattunement = 6;
                    this.baseendurance = 12;
                    this.basevitality = 11;
                    this.basestrenght = 16;
                    this.basedexterity = 9;
                    this.baseintelligence = 8;
                    this.basefaith = 9;
                    this.baseluck = 11;
                    break;
                case "Herald":
                    this.level = 9;
                    this.vigor = 12;
                    this.attunement = 10;
                    this.endurance = 9;
                    this.vitality = 12;
                    this.strenght = 12;
                    this.dexterity = 11;
                    this.intelligence = 8;
                    this.faith = 13;
                    this.luck = 11;
                    this.baselevel = 9;
                    this.basevigor = 12;
                    this.baseattunement = 10;
                    this.baseendurance = 9;
                    this.basevitality = 12;
                    this.basestrenght = 12;
                    this.basedexterity = 11;
                    this.baseintelligence = 8;
                    this.basefaith = 13;
                    this.baseluck = 11;
                    break;
                case "Thief":
                    this.level = 5;
                    this.vigor = 10;
                    this.attunement = 11;
                    this.endurance = 10;
                    this.vitality = 9;
                    this.strenght = 9;
                    this.dexterity = 13;
                    this.intelligence = 10;
                    this.faith = 8;
                    this.luck = 14;
                    this.baselevel = 5;
                    this.basevigor = 10;
                    this.baseattunement = 11;
                    this.baseendurance = 10;
                    this.basevitality = 9;
                    this.basestrenght = 9;
                    this.basedexterity = 13;
                    this.baseintelligence = 10;
                    this.basefaith = 8;
                    this.baseluck = 14;
                    break;
                case "Assassin":
                    this.level = 10;
                    this.vigor = 10;
                    this.attunement = 14;
                    this.endurance = 11;
                    this.vitality = 10;
                    this.strenght = 10;
                    this.dexterity = 14;
                    this.intelligence = 11;
                    this.faith = 9;
                    this.luck = 10;
                    this.baselevel = 10;
                    this.basevigor = 10;
                    this.baseattunement = 14;
                    this.baseendurance = 11;
                    this.basevitality = 10;
                    this.basestrenght = 10;
                    this.basedexterity = 14;
                    this.baseintelligence = 11;
                    this.basefaith = 9;
                    this.baseluck = 10;
                    break;
                case "Sorcerer":
                    this.level = 6;
                    this.vigor = 9;
                    this.attunement = 16;
                    this.endurance = 9;
                    this.vitality = 7;
                    this.strenght = 7;
                    this.dexterity = 12;
                    this.intelligence = 16;
                    this.faith = 7;
                    this.luck = 12;
                    this.baselevel = 6;
                    this.basevigor = 9;
                    this.baseattunement = 16;
                    this.baseendurance = 9;
                    this.basevitality = 7;
                    this.basestrenght = 7;
                    this.basedexterity = 12;
                    this.baseintelligence = 16;
                    this.basefaith = 7;
                    this.baseluck = 12;
                    break;
                case "Pyromancer":
                    this.level = 8;
                    this.vigor = 11;
                    this.attunement = 12;
                    this.endurance = 10;
                    this.vitality = 18;
                    this.strenght = 12;
                    this.dexterity = 9;
                    this.intelligence = 14;
                    this.faith = 14;
                    this.luck = 7;
                    this.baselevel = 8;
                    this.basevigor = 11;
                    this.baseattunement = 12;
                    this.baseendurance = 10;
                    this.basevitality = 18;
                    this.basestrenght = 12;
                    this.basedexterity = 9;
                    this.baseintelligence = 14;
                    this.basefaith = 14;
                    this.baseluck = 7;
                    break;
                case "Cleric":
                    this.level = 7;
                    this.vigor = 10;
                    this.attunement = 14;
                    this.endurance = 9;
                    this.vitality = 7;
                    this.strenght = 12;
                    this.dexterity = 8;
                    this.intelligence = 7;
                    this.faith = 16;
                    this.luck = 13;
                    this.baselevel = 7;
                    this.basevigor = 10;
                    this.baseattunement = 14;
                    this.baseendurance = 9;
                    this.basevitality = 7;
                    this.basestrenght = 12;
                    this.basedexterity = 8;
                    this.baseintelligence = 7;
                    this.basefaith = 16;
                    this.baseluck = 13;
                    break;
                case "Deprived":
                    this.level = 1;
                    this.vigor = 10;
                    this.attunement = 10;
                    this.endurance = 10;
                    this.vitality = 10;
                    this.strenght = 10;
                    this.dexterity = 10;
                    this.intelligence = 10;
                    this.faith = 10;
                    this.luck = 10;
                    this.baselevel = 1;
                    this.basevigor = 10;
                    this.baseattunement = 10;
                    this.baseendurance = 10;
                    this.basevitality = 10;
                    this.basestrenght = 10;
                    this.basedexterity = 10;
                    this.baseintelligence = 10;
                    this.basefaith = 10;
                    this.baseluck = 10;
                    break;
            }
        }

    }
}
