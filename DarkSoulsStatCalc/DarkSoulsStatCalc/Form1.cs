using MaterialSkin.Controls;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DarkSoulsStatCalc
{
    public partial class Form1 : MaterialForm
    {
        /*private List<Item> Protector;
        private List<Item> Rings;
        private List<Item> Weapons;*/

        public Form1()
        {
            InitializeComponent();

            // Protector = CSV.Read("ObjectData/Protector.csv");
            // Rings = CSV.Read("ObjectData/Rings.csv");
            // Weapons = CSV.Read("ObjectData/Weapons.csv");
        }

        public void LoadRings()
        {
            List<Ring> RingList = new List<Ring>();
            
            //Havel
            Ring Havel = new Ring();
            Havel.Name = "Havel";
            Havel.Weight = 1.5;
            RingList.Add(Havel);

            //FAP
            Ring FAP = new Ring();
            FAP.Name = "FAP";
            FAP.Weight = 1.5;
            RingList.Add(FAP);            

            //Cloranthy
            Ring Chloranthy = new Ring();
            Chloranthy.Name = "Cloranthy";
            Chloranthy.Weight = 0.7;
            RingList.Add(Chloranthy);

            //ADD RINGS
            //...
            //...

            //Ring Combobox1
            rings1.DataSource = RingList;
            rings1.DisplayMember = "Name";
            rings1.ValueMember = "Weight";
            rings1.SelectedItem = null;

            ///Ring Combobox2
            rings2.DataSource = RingList;
            rings2.DisplayMember = "Name";
            rings2.ValueMember = "Weight";
            rings2.SelectedItem = null;

            //Ring Combobox3
            rings3.DataSource = RingList;
            rings3.DisplayMember = "Name";
            rings3.ValueMember = "Weight";
            rings3.SelectedItem = null;

            //Ring Combobox4
            rings4.DataSource = RingList;
            rings4.DisplayMember = "Name";
            rings4.ValueMember = "Weight";
            rings4.SelectedItem = null;
        }

        public void LoadWeapons()
        {
            List<weapon> weaponList = new List<weapon>();

            //Ancient Dragon Great Shield
            weapon Ancient_Dragon_Great_Shield = new weapon();
            Ancient_Dragon_Great_Shield.Name = "Ancient Dragon Great Shield";
            Ancient_Dragon_Great_Shield.Weight = 6.5;
            weaponList.Add(Ancient_Dragon_Great_Shield);

            //Ancient Dragon Halberd
            weapon Ancient_Dragon_Halberd = new weapon();
            Ancient_Dragon_Halberd.Name = "Ancient Dragon Halberd";
            Ancient_Dragon_Halberd.Weight = 6.5;
            weaponList.Add(Ancient_Dragon_Halberd);

            //Anri's Straight Sword
            weapon Anris_Straight_Sword = new weapon();
            Anris_Straight_Sword.Name = "Anri's Straight Sword";
            Anris_Straight_Sword.Weight = 3.0;
            weaponList.Add(Anris_Straight_Sword);

            

            //ADD weapons
            //...
            //...

            //Lweapon1
            Lweapon1.DataSource = weaponList;
            Lweapon1.DisplayMember = "Name";
            Lweapon1.ValueMember = "Weight";
            Lweapon1.SelectedItem = null;

            //Lweapon2
            Lweapon2.DataSource = weaponList;
            Lweapon2.DisplayMember = "Name";
            Lweapon2.ValueMember = "Weight";
            Lweapon2.SelectedItem = null;

            //Lweapon3
            Lweapon3.DataSource = weaponList;
            Lweapon3.DisplayMember = "Name";
            Lweapon3.ValueMember = "Weight";
            Lweapon3.SelectedItem = null;

            //Rweapon1
            Rweapon1.DataSource = weaponList;
            Rweapon1.DisplayMember = "Name";
            Rweapon1.ValueMember = "Weight";
            Rweapon1.SelectedItem = null;

            //Rweapon2
            Rweapon2.DataSource = weaponList;
            Rweapon2.DisplayMember = "Name";
            Rweapon2.ValueMember = "Weight";
            Rweapon2.SelectedItem = null;

            //Rweapon3
            Rweapon3.DataSource = weaponList;
            Rweapon3.DisplayMember = "Name";
            Rweapon3.ValueMember = "Weight";
            Rweapon3.SelectedItem = null;
        }

        public void LoadArmor()
        {
            List<armor> armorList = new List<armor>();

            //Alva Armor
            armor Alva_Armor = new armor();
            Alva_Armor.Name = "Alva Armor";
            Alva_Armor.Weight = 9;
            armorList.Add(Alva_Armor);


            //armor1
            armor1.DataSource = armorList;
            armor1.DisplayMember = "Name";
            armor1.ValueMember = "Weight";
            armor1.SelectedItem = null;

            //armor2
            armor2.DataSource = armorList;
            armor2.DisplayMember = "Name";
            armor2.ValueMember = "Weight";
            armor2.SelectedItem = null;

            //armor3
            armor3.DataSource = armorList;
            armor3.DisplayMember = "Name";
            armor3.ValueMember = "Weight";
            armor3.SelectedItem = null;

            //armor4
            armor4.DataSource = armorList;
            armor4.DisplayMember = "Name";
            armor4.ValueMember = "Weight";
            armor4.SelectedItem = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Search for updates
            WebClient webClient = new WebClient();
            if (!webClient.DownloadString("https://pastebin.com/raw/4SDWV9m4").Contains("1.0"))
            {
                if (MessageBox.Show("Update available", "DSIIIStatCalcUpdater", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start("https://github.com/PapaElGunmen/DarkSoulsStatCalculator/releases");
                }
                else
                {

                }
            }

            //Init
            LoadRings();
            LoadWeapons();
            LoadArmor();

        }

        //Calculate weight
        public double Weightsum()
        {
            double weight = 0;

            //Rings1
            if (rings1.SelectedItem != null)
            {
                Ring ring1 = rings1.SelectedItem as Ring;
                weight = weight + ring1.Weight;
            }

            //Rings2
            if (rings2.SelectedItem != null)
            {
                Ring ring2 = rings2.SelectedItem as Ring;
                weight = weight + ring2.Weight;
            }

            //Rings3
            if (rings3.SelectedItem != null)
            {
                Ring ring3 = rings3.SelectedItem as Ring;
                weight = weight + ring3.Weight;
            }

            //Rings4
            if (rings4.SelectedItem != null)
            {
                Ring ring4 = rings4.SelectedItem as Ring;
                weight = weight + ring4.Weight;
            }

            //Lweapon1
            if (Lweapon1.SelectedItem != null)
            {
                weapon weapon1 = Lweapon1.SelectedItem as weapon;
                weight = weight + weapon1.Weight;
            }

            //Lweapon2
            if (Lweapon2.SelectedItem != null)
            {
                weapon weapon2 = Lweapon2.SelectedItem as weapon;
                weight = weight + weapon2.Weight;
            }

            //Lweapon3
            if (Lweapon3.SelectedItem != null)
            {
                weapon weapon3 = Lweapon3.SelectedItem as weapon;
                weight = weight + weapon3.Weight;
            }

            //Rweapon1
            if (Rweapon1.SelectedItem != null)
            {
                weapon weapon4 = Rweapon1.SelectedItem as weapon;
                weight = weight + weapon4.Weight;
            }

            //Rweapon2
            if (Rweapon2.SelectedItem != null)
            {
                weapon weapon5 = Rweapon2.SelectedItem as weapon;
                weight = weight + weapon5.Weight;
            }

            //Rweapon3
            if (Rweapon3.SelectedItem != null)
            {
                weapon weapon6 = Rweapon3.SelectedItem as weapon;
                weight = weight + weapon6.Weight;
            }

            return weight;
        }

        private void rings1_SelectedIndexChanged(object sender, EventArgs e)
        {
            double sum = Weightsum();
            //vitcalc();
            //Vitlbl.Text = sum.ToString();
        }

        //Vit Calc
         public void vitcalc()
         {
             double rollpercent = 29.9;
             double vitality;
             int cont = 0;
             double weight;
             int finished = 0;
             List<int> vitstats = new List<int>();
             List<int> vitlvl = new List<int>();
            //Add items to list
            vitstats.Add(47);
            vitstats.Add(50);
            vitstats.Add(55);
            vitstats.Add(60);
            vitstats.Add(65);
            vitstats.Add(70);
            vitstats.Add(75);
            vitstats.Add(80);
            vitstats.Add(85);
            vitstats.Add(90);
            vitstats.Add(95);
            vitstats.Add(100);
            vitstats.Add(105);
            vitstats.Add(110);
            vitstats.Add(115);
            vitstats.Add(120);
            vitstats.Add(125);
            vitstats.Add(130);
            vitstats.Add(135);
            vitstats.Add(139);

            vitlvl.Add(7);
            vitlvl.Add(10);
            vitlvl.Add(15);
            vitlvl.Add(20);
            vitlvl.Add(25);
            vitlvl.Add(30);
            vitlvl.Add(35);
            vitlvl.Add(40);
            vitlvl.Add(45);
            vitlvl.Add(50);
            vitlvl.Add(55);
            vitlvl.Add(60);
            vitlvl.Add(65);
            vitlvl.Add(70);
            vitlvl.Add(75);
            vitlvl.Add(80);
            vitlvl.Add(85);
            vitlvl.Add(90);
            vitlvl.Add(95);
            vitlvl.Add(99);


            //weight = float.Parse(weightbox.Text);
            weight = Weightsum();

             //Selec kind of roll
             if (Fastrb.Checked)
             {
                 rollpercent = 29.9;
             }
             if (Normalrb.Checked)
             {
                 rollpercent = 69.9;
             }
             if (Fatrb.Checked)
             {
                 rollpercent = 99.9;
             }

             //Calculate vitality lvl
             vitality = weight * 100.0 / rollpercent;

             //Select lvl
             while (finished == 0)
             {
                 //Search lvl comparing vitality stats in both lists
                 if(vitality <= vitstats[cont])
                 {
                     finished = 1;
                 }
                 else
                 {
                     cont += 1;
                 }
             }

             ////////////////////////////////////
             //Añadir excepcion weight>139 peta//
             ////////////////////////////////////

            //Show result
            Vitlbl.Text = vitlvl[cont].ToString();
         }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            vitcalc();
        }
    }
}
