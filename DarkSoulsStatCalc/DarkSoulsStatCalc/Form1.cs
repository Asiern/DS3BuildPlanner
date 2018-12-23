using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DarkSoulsStatCalc
{
    public partial class Form1 : Form
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

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Lweapon1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Theme Change
            if (DarkSoulsStatCalc.Properties.Settings.Default.Theme == "Light")
            {
                //Vitality
                Vitpage.ForeColor = SystemColors.ActiveCaptionText;
                Vitpage.BackgroundImage = DarkSoulsStatCalc.Properties.Resources.Vitlight;
                Fastcheckbox.ForeColor = SystemColors.ActiveCaptionText;
                Normalcheckbox.ForeColor = SystemColors.ActiveCaptionText;
                Fatcheckbox.ForeColor = SystemColors.ActiveCaptionText;

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

            if (DarkSoulsStatCalc.Properties.Settings.Default.Theme == "Dark")
            {
                //Vitality
                Vitpage.BackgroundImage = DarkSoulsStatCalc.Properties.Resources.Vitdark;
                Vitpage.ForeColor = SystemColors.ControlLightLight;
                Fastcheckbox.ForeColor = SystemColors.ControlLightLight;
                Normalcheckbox.ForeColor = SystemColors.ControlLightLight;
                Fatcheckbox.ForeColor = SystemColors.ControlLightLight;


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

        private void Fastcheckbox_CheckedChanged(object sender, EventArgs e)
        {
             
        }

        private void Normalcheckbox_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void Fatcheckbox_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
