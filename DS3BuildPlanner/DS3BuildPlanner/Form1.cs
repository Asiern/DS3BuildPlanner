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
        public Form1()
        {
            InitializeComponent();

            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            test();

        }

        //THEME
        private void updateColor()
        {
            switch (Properties.Settings.Default.colorSchemeIndex)
            {
                case 0:
                    materialSkinManager.ColorScheme = new ColorScheme(
                        materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? Primary.Teal500 : Primary.Indigo500,
                        materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? Primary.Teal700 : Primary.Indigo700,
                        materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? Primary.Teal200 : Primary.Indigo100,
                        Accent.Pink200,
                        TextShade.WHITE);
                    break;

                case 1:
                    materialSkinManager.ColorScheme = new ColorScheme(
                        Primary.Green600,
                        Primary.Green700,
                        Primary.Green200,
                        Accent.Red100,
                        TextShade.WHITE);
                    break;

                case 2:
                    materialSkinManager.ColorScheme = new ColorScheme(
                        Primary.BlueGrey800,
                        Primary.BlueGrey900,
                        Primary.BlueGrey500,
                        Accent.LightBlue200,
                        TextShade.WHITE);
                    break;
            }
            Invalidate();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void materialComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            updateColor();
        }

        private void materialComboBox1_TabIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.colorSchemeIndex = materialComboBox1.SelectedIndex;
        }

        private void materialSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (!materialSwitch1.Checked) { materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT; }
            else { materialSkinManager.Theme = MaterialSkinManager.Themes.DARK; }
            
        }

        //TESTING
        private void test()
        {
            List<Armor> chestList = new List<Armor>();

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
                    Armor chest = new Armor(name, physicalAbsortion, magicAbsortion, fireAbsortion, lightningAbsortion, darkAbsortion, bleedResistance, poisonResistance, 
                        frostResistance, curseResistance, poise, weight, poiseWeightRatio);
                    chestList.Add(chest);
                }
            }



            var bindingSource1 = new BindingSource();
            bindingSource1.DataSource = chestList;
            //chest
            testcb.DataSource = bindingSource1.DataSource;
            testcb.DisplayMember = "name";
            //testcb.ValueMember = weight;
            testcb.SelectedItem = null;
            testcb.SelectedIndex = 0;
        }
    }
}
