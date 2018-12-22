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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.Show();
        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void Settingsapply_Click(object sender, EventArgs e)
        {
            //Este Boton no funciona bien
            if(combobox7.SelectedItem == "Default")
            {
                DarkSoulsStatCalc.Properties.Settings.Default.Theme = "Default";
            }
            if (combobox7.SelectedItem == "Dark")
            {
                DarkSoulsStatCalc.Properties.Settings.Default.Theme = "Dark";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Theme Change
            if (DarkSoulsStatCalc.Properties.Settings.Default.Theme == "Default")
            {
                Vitpage.ForeColor = SystemColors.ActiveCaptionText;
                Soulpage.ForeColor = SystemColors.ActiveCaptionText;
                //Soulpage.BackgroundImage = DarkSoulsStatCalc.Properties.Resources.Soullight;
                Settings.ForeColor = SystemColors.ActiveCaptionText;
                //Settings.BackgroundImage = DarkSoulsStatCalc.Properties.Resources.Settlight;
                Vitpage.BackgroundImage = DarkSoulsStatCalc.Properties.Resources.Vitlight;
                //Cambiar color de fondo form1 a "Systemcolors.buttonface"
                //Cambiar color de Tab control
            }

            if (DarkSoulsStatCalc.Properties.Settings.Default.Theme == "Dark")
            {
                Vitpage.BackgroundImage = DarkSoulsStatCalc.Properties.Resources.Vitdark;
                Vitpage.ForeColor = SystemColors.ControlLightLight;
                Soulpage.ForeColor = SystemColors.ControlLightLight;
                //Soulpage.BackgroundImage = DarkSoulsStatCalc.Properties.Resources.Souldark;
                Settings.ForeColor = SystemColors.ControlLightLight;
                //Settings.BackgroundImage = DarkSoulsStatCalc.Properties.Resources.Settdark;
                //Cambiar color de fondo form1 a #353535
                //Cambiar color de Tab control
            }
        }
    }
}
