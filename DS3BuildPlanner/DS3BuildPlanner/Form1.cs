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
        Stats s = Stats.getInstance();
        Updater u = new Updater();
        Player p = new Player();
        Equipment e = Equipment.getInstance();
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

            //Class select Knight as Default
            classcb.SelectedIndex = 0;

            //test();
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
            Properties.Settings.Default.ThemeAccent = Accent.Green700;
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            p.setupPlayer(classcb.Text);
            ShowPlayer();
        }

        public void ShowPlayer()
        {
            vigorbase.Text = p.getbaseVigor().ToString();
            attunementbase.Text = p.getbaseAttunement().ToString();
            endurancebase.Text = p.getbaseEndurance().ToString();
            vitalitybase.Text = p.getbaseVitality().ToString();
            strenghtbase.Text = p.getbaseStrenght().ToString();
            dexteritybase.Text = p.getbaseDexterity().ToString();
            intelligencebase.Text = p.getbaseIntelligence().ToString();
            faithbase.Text = p.getbaseFaith().ToString();
            luckbase.Text = p.getbaseLuck().ToString();
            levelbtn.Text = p.getLevel().ToString();

            vigor.Text = p.getVigor().ToString();
            attunement.Text = p.getAttunement().ToString();
            endurance.Text = p.getEndurance().ToString();
            vitality.Text = p.getVitality().ToString();
            strenght.Text = p.getStrenght().ToString();
            dexterity.Text = p.getDexterity().ToString();
            intelligence.Text = p.getIntelligence().ToString();
            faith.Text = p.getFaith().ToString();
            luck.Text = p.getLuck().ToString();
            levelbtn.Text = p.getLevel().ToString();

            //Attunement         

            p.calculateAttunementSlots();
            attunementslotsbtn.Text = p.getAttunementSlots().ToString();

            calculateSouls();
            calculateFP();
            calculateHP();
            calculateStamina();
            calculateItemDiscovery();
        }

        private void addvigor_Click(object sender, EventArgs e)
        {
            if (p.getVigor() < 99)
            {
                p.setVigor(p.getVigor() + 1);
                p.setLevel(p.getLevel() + 1);
                ShowPlayer();

            }
        }

        private void subvigor_Click(object sender, EventArgs e)
        {
            if (p.getVigor() > p.getbaseVigor())
            {
                p.setVigor(p.getVigor() - 1);
                p.setLevel(p.getLevel() - 1);
                ShowPlayer();
            }
        }

        private void addattunement_Click(object sender, EventArgs e)
        {
            if (p.getAttunement() < 99)
            {
                p.setAttunement(p.getAttunement() + 1);
                p.setLevel(p.getLevel() + 1);
                ShowPlayer();
            }
        }

        private void subattunement_Click(object sender, EventArgs e)
        {
            if (p.getAttunement() > p.getbaseAttunement())
            {
                p.setAttunement(p.getAttunement() - 1);
                p.setLevel(p.getLevel() - 1);
                ShowPlayer();
            }
        }

        private void addendurance_Click(object sender, EventArgs e)
        {
            if (p.getEndurance() < 99)
            {
                p.setEndurance(p.getEndurance() + 1);
                p.setLevel(p.getLevel() + 1);
                ShowPlayer();
            }
        }

        private void subendurance_Click(object sender, EventArgs e)
        {
            if (p.getEndurance() > p.getbaseEndurance())
            {
                p.setEndurance(p.getEndurance() - 1);
                p.setLevel(p.getLevel() - 1);
                ShowPlayer();
            }
        }

        private void addvitality_Click(object sender, EventArgs e)
        {
            if (p.getVitality() < 99)
            {
                p.setVitality(p.getVitality() + 1);
                p.setLevel(p.getLevel() + 1);
                ShowPlayer();
            }
        }

        private void subvitality_Click(object sender, EventArgs e)
        {
            if (p.getVitality() > p.getbaseVitality())
            {
                p.setVitality(p.getVitality() - 1);
                p.setLevel(p.getLevel() - 1);
                ShowPlayer();
            }
        }

        private void addstrength_Click(object sender, EventArgs e)
        {
            if (p.getStrenght() < 99)
            {
                p.setStrenght(p.getStrenght() + 1);
                p.setLevel(p.getLevel() + 1);
                ShowPlayer();
            }
        }

        private void substrenght_Click(object sender, EventArgs e)
        {
            if (p.getStrenght() > p.getbaseStrenght())
            {
                p.setStrenght(p.getStrenght() - 1);
                p.setLevel(p.getLevel() - 1);
                ShowPlayer();
            }
        }

        private void adddexterity_Click(object sender, EventArgs e)
        {
            if (p.getDexterity() < 99)
            {
                p.setDexterity(p.getDexterity() + 1);
                p.setLevel(p.getLevel() + 1);
                ShowPlayer();
            }
        }

        private void subdexterity_Click(object sender, EventArgs e)
        {
            if (p.getDexterity() > p.getbaseDexterity())
            {
                p.setDexterity(p.getDexterity() - 1);
                p.setLevel(p.getLevel() - 1);
                ShowPlayer();
            }
        }

        private void addintelligence_Click(object sender, EventArgs e)
        {
            if (p.getIntelligence() < 99)
            {
                p.setIntelligence(p.getIntelligence() + 1);
                p.setLevel(p.getLevel() + 1);
                ShowPlayer();
            }
        }

        private void subintelligence_Click(object sender, EventArgs e)
        {
            if (p.getIntelligence() > p.getbaseIntelligence())
            {
                p.setIntelligence(p.getIntelligence() - 1);
                p.setLevel(p.getLevel() - 1);
                ShowPlayer();
            }
        }

        private void addfaith_Click(object sender, EventArgs e)
        {
            if (p.getFaith() < 99)
            {
                p.setFaith(p.getFaith() + 1);
                p.setLevel(p.getLevel() + 1);
                ShowPlayer();
            }
        }

        private void subfaith_Click(object sender, EventArgs e)
        {
            if (p.getFaith() > p.getbaseFaith())
            {
                p.setFaith(p.getFaith() - 1);
                p.setLevel(p.getLevel() - 1);
                ShowPlayer();
            }
        }

        private void addluck_Click(object sender, EventArgs e)
        {
            if (p.getLuck() < 99)
            {
                p.setLuck(p.getLuck() + 1);
                p.setLevel(p.getLevel() + 1);
                ShowPlayer();
            }
        }

        private void subluck_Click(object sender, EventArgs e)
        {
            if (p.getLuck() > p.getbaseLuck())
            {
                p.setLuck(p.getLuck() - 1);
                p.setLevel(p.getLevel() - 1);
                ShowPlayer();
            }
        }

        public void calculateSouls()
        {
            nextSouls.Text = s.soulsToNextLevel(p.getLevel()).ToString();
            totalSouls.Text = s.calculateSouls(p.getbaseLevel(), p.getLevel()).ToString();
        }

        public void calculateFP()
        {
            p.setFP(s.calculateFP(p.getAttunement()));
            FPbtn.Text = p.getFP().ToString();
        }

        public void calculateHP()
        {
            p.setHP(s.calculateHP(p.getVigor()));
            //HPbtn.Text = p.getHP().ToString()+"("+(p.getHP()+ p.getHP()*0.3).ToString() + ")";
            HPbtn.Text = p.getHP().ToString();
        }
        public void calculateStamina()
        {
            p.setStamina(s.calculateStamina(p.getEndurance()));
            staminabtn.Text = p.getStamina().ToString();
        }
        public void calculateItemDiscovery()
        {
            p.setItemDiscovery(p.getLuck()+100);
            itemdiscoverybtn.Text = p.getItemDiscovery().ToString();
        }
    }
}

