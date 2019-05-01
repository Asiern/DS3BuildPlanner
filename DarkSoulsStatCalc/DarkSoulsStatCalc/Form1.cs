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
        private List<Item> Protector;
        private List<Item> Rings;
        private List<Item> Weapons;

        public Form1()
        {
            InitializeComponent();

            // Protector = CSV.Read("ObjectData/Protector.csv");
            // Rings = CSV.Read("ObjectData/Rings.csv");
            // Weapons = CSV.Read("ObjectData/Weapons.csv");
        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

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

            //Anri's Straight Sword
            weapon Anris_Straight_Sword = new weapon();
            Anris_Straight_Sword.Name = "Anri's Straight Sword";
            Anris_Straight_Sword.Weight = 3.0;
            weaponList.Add(Anris_Straight_Sword);

            //Ancient Dragon Great Shield
            weapon Ancient_Dragon_Great_Shield = new weapon();
            Ancient_Dragon_Great_Shield.Name = "Ancient Dragon Great Shield";
            Ancient_Dragon_Great_Shield.Weight = 6.5;
            weaponList.Add(Ancient_Dragon_Great_Shield);

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

            LoadRings();
            LoadWeapons();                  


        }

        //Calculate weight
        public  int Weightsum()
        {
            return 1;
        }

        //Vit Calc
       /* public void vitcalc()
        {
            double rollpercent = 29.9;
            double vitality;
            int cont = 0;
            double weight;
            int finished = 0;
            List<int> vitstats = new List<int>();
            //Add items to list

            //weight = float.Parse(weightbox.Text);
            weight = weightsum();

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

            //Show result
            Vitlbl.Text = char.Parse(cont);
        }*/

        /*private void timer1_Tick(object sender, EventArgs e)
        {
            //Theme Change
            //Light Theme
            if (DarkSoulsStatCalc.Properties.Settings.Default.Theme == "Light")
            {
                //Vitality
                Vitpage.ForeColor = SystemColors.ActiveCaptionText;
                Vitpage.BackgroundImage = DarkSoulsStatCalc.Properties.Resources.Vitlight;
                Fastrb.ForeColor = SystemColors.ActiveCaptionText;
                Normalrb.ForeColor = SystemColors.ActiveCaptionText;
                Fatrb.ForeColor = SystemColors.ActiveCaptionText;

                //Souls
                Soulpage.ForeColor = SystemColors.ActiveCaptionText;
                //Soulpage.BackgroundImage = DarkSoulsStatCalc.Properties.Resources.Soullight;

                //Settings
                //Settings.ForeColor = SystemColors.ActiveCaptionText;
                Settings.BackgroundImage = DarkSoulsStatCalc.Properties.Resources.Settlight;
                Settings.BackColor = Color.FromArgb(255,255,255);
                
                //Cambiar color de fondo form1 a "Systemcolors.buttonface"
                this.BackColor = SystemColors.ButtonFace;
                //Cambiar color de Tab control a "SystemColors.ButtonFace"
            }
            //Dark Theme
            if (DarkSoulsStatCalc.Properties.Settings.Default.Theme == "Dark")
            {
                //Vitality
                Vitpage.BackgroundImage = DarkSoulsStatCalc.Properties.Resources.Vitdark;
                Vitpage.ForeColor = SystemColors.ControlLightLight;
                Fastrb.ForeColor = SystemColors.ControlLightLight;
                Normalrb.ForeColor = SystemColors.ControlLightLight;
                Fatrb.ForeColor = SystemColors.ControlLightLight;


                //Souls
                Soulpage.ForeColor = SystemColors.ControlLightLight;
                //Soulpage.BackgroundImage = DarkSoulsStatCalc.Properties.Resources.Souldark;


                //Settings
                //Settings.ForeColor = SystemColors.ControlLightLight;
                Settings.BackgroundImage = DarkSoulsStatCalc.Properties.Resources.Settdark;
                Settings.BackColor = Color.FromArgb(37, 37, 37);
               
                
                //Cambiar color de fondo form1 a #353535
                this.BackColor = Color.FromArgb(53,53,53);
                //Cambiar color de Tab control a #353535 y #252525
                
            }
        }
        */

        private void LightThemebut_Click(object sender, EventArgs e)
        {
            DarkSoulsStatCalc.Properties.Settings.Default.Theme = "Light";
        }

        private void DarkThemebut_Click(object sender, EventArgs e)
        {
            DarkSoulsStatCalc.Properties.Settings.Default.Theme = "Dark";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Ring Selected = comboBox1.SelectedItem as Ring;
            //Vitlbl.Text = Selected.Name;

        }
    }
}
