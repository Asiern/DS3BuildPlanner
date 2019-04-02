using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

      
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
 
        }
        
        
        //Ring Object
        class Ring
        {
            string name;
            double weight;
            public Ring (string name, float weight)
            {
                name = name;
                weight = weight;
            }
            public string Name { get => name; set => name = value; }
            public double Weight { get => weight; set => weight = value; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //Load Rings List
            ArrayList RingList = new ArrayList();
            RingList.Add(new Ring("Name", 03));

            //Load Ring ComboBox
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            foreach (Ring item in RingList)
            {
                Console.WriteLine("Name:{0} Weight:{1}", item.Name, item.Weight);
            }

        }


        //Vit Calc
        /*public void vitcalc()
        {
            float rollpercent;
            float vitality;
            int cont = 0;
            float weight;
            int finished = 0;
            List<int> vitstats = new List<int>();
            //Add items to list
                    
            weight = float.Parse(weightbox.Text);

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

    }
}
