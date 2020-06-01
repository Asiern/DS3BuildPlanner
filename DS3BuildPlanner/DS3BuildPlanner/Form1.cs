using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DS3BuildPlanner
{
    public partial class Form1 : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        List<Armor> chestList = new List<Armor>();
        souls s = souls.getInstance();
        Updater u = new Updater();
        Player p = new Player();
        public Form1()
        {
            InitializeComponent();

            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);

            //if (Properties.Settings.Default.ThemePrimary1 == null)
            //{
                Properties.Settings.Default.ThemePrimary1 = Primary.Green600;
                Properties.Settings.Default.ThemePrimary2 = Primary.Green700;
                Properties.Settings.Default.ThemePrimary3 = Primary.Green200;
                Properties.Settings.Default.ThemeAccent = Accent.Red100;
                Properties.Settings.Default.ThemeTextShade = TextShade.WHITE;
                Properties.Settings.Default.Save();
            //}
            loadTheme();

            //Search for updates
            u.update();

            test();
            //seedListView(chestList[1]);

        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //DARK MODE
        private void materialSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (!materialSwitch1.Checked) { Properties.Settings.Default.Theme = "LIGHT"; }
            else { Properties.Settings.Default.Theme = "DARK"; }
            Properties.Settings.Default.Save();
            loadTheme();
            
        }

        //TESTING
        private void test()
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
                    /*Armor chest = new Armor(name, physicalAbsortion, magicAbsortion, fireAbsortion, lightningAbsortion, darkAbsortion, bleedResistance, poisonResistance, 
                        frostResistance, curseResistance, poise, weight, poiseWeightRatio);*/
                    Armor chest = new Armor();
                    chest.Name = name;
                    chestList.Add(chest);
                }
            }



            //chest
            /**comboBox1.DataSource = chestList;
            comboBox1.DisplayMember = "name";
            comboBox1.SelectedItem = null;
            comboBox1.SelectedIndex = 0;**/
        }

        private void seedListView(Armor a)
        {
            //Armor to String
            //Define
            var data = new[]
            {
                new []{a.Name, a.PhysicalAbsortion.ToString(), a.MagicAbsortion.ToString(), a.FireAbsortion.ToString(), a.LightningAbsortion.ToString(), a.DarkAbsortion.ToString(), a.BleedResistance.ToString(), a.PoisonResistance.ToString(), a.FrostResistance.ToString(), a.CurseResistance.ToString(), a.Poise.ToString(), a.Weight.ToString(), a.PoiseWeightRatio.ToString() },
            };

            //Add
            foreach (string[] version in data)
            {
                var item = new ListViewItem(version);
                materialListView1.Items.Add(item);
            }
        }

        private void materialComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (materialComboBox2.SelectedIndex)
            {
                case 0:
                    pictureBox1.Image = Image.FromFile("map/mp_firelink_shrine/mp_firelink_shrine.jpg");
                    break;
                case 1:
                    pictureBox1.Image = Image.FromFile("map/mp_cemetery_of_ash/mp_cemetery_of_ash.jpg");
                    break;
            }
        }
        private void loadTheme()
        {
            materialSkinManager.ColorScheme = new ColorScheme(
                        Properties.Settings.Default.ThemePrimary1,
                        Properties.Settings.Default.ThemePrimary2,
                        Properties.Settings.Default.ThemePrimary3,
                        Properties.Settings.Default.ThemeAccent,
                        Properties.Settings.Default.ThemeTextShade);
            if (Properties.Settings.Default.Theme == "DARK")
            {
                materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
                materialSwitch1.Checked = true;
            }
            else
            {
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
                materialSwitch1.Checked = false;
            }
        }
        private void materialButton3_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ThemePrimary1 = Primary.Green600;
            Properties.Settings.Default.ThemePrimary2 = Primary.Green700;
            Properties.Settings.Default.ThemePrimary3 = Primary.Green200;
            Properties.Settings.Default.ThemeAccent = Accent.Red100;
            Properties.Settings.Default.ThemeTextShade = TextShade.WHITE;
            Properties.Settings.Default.Theme = "LIGHT";
            Properties.Settings.Default.Save();
            loadTheme();
        }

        private void materialButton4_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ThemePrimary1 = Primary.Orange600;
            Properties.Settings.Default.ThemePrimary2 = Primary.Orange700;
            Properties.Settings.Default.ThemePrimary3 = Primary.Orange200;
            Properties.Settings.Default.ThemeAccent = Accent.Blue100;
            Properties.Settings.Default.ThemeTextShade = TextShade.WHITE;
            Properties.Settings.Default.Theme = "DARK";
            Properties.Settings.Default.Save();
            loadTheme();
        }

        private void materialButton5_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ThemePrimary1 = Primary.Green600;
            Properties.Settings.Default.ThemePrimary2 = Primary.Green700;
            Properties.Settings.Default.ThemePrimary3 = Primary.Green200;
            Properties.Settings.Default.ThemeAccent = Accent.Red100;
            Properties.Settings.Default.ThemeTextShade = TextShade.WHITE;
            Properties.Settings.Default.Theme = "DARK";
            Properties.Settings.Default.Save();
            loadTheme();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            /*try
            {
               * string souls = s.calculateSouls(int.Parse(materialTextBox1.Text), int.Parse(materialTextBox2.Text)).ToString();
                //materialLabel3.Text = s.calculateSouls(15,23).ToString();
                materialLabel3.Text = (souls+" souls will be needed to get from level "+ materialTextBox1.Text+" to level "+ materialTextBox2.Text);
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }*/
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            p.setupPlayer(comboBox1.Text);
            ShowPlayer();
        }

        public void ShowPlayer()
        {
            vigorbase.Text = p.getVigor().ToString();
            attunementbase.Text = p.getAttunement().ToString();
            endurancebase.Text = p.getEndurance().ToString();
            vitalitybase.Text = p.getVitality().ToString();
            strenghtbase.Text = p.getStrenght().ToString();
            dexteritybase.Text = p.getDexterity().ToString();
            intelligencebase.Text = p.getIntelligence().ToString();
            faithbase.Text = p.getFaith().ToString();
            luckbase.Text = p.getLuck().ToString();
            levelbtn.Text = p.getLevel().ToString();
        }
    }
}
