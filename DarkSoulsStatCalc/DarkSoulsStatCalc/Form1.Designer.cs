namespace DarkSoulsStatCalc
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.About = new System.Windows.Forms.TabControl();
            this.Vitpage = new System.Windows.Forms.TabPage();
            this.Aboutlink = new System.Windows.Forms.LinkLabel();
            this.comboBox13 = new System.Windows.Forms.ComboBox();
            this.comboBox12 = new System.Windows.Forms.ComboBox();
            this.comboBox11 = new System.Windows.Forms.ComboBox();
            this.comboBox10 = new System.Windows.Forms.ComboBox();
            this.rings4 = new System.Windows.Forms.ComboBox();
            this.rings3 = new System.Windows.Forms.ComboBox();
            this.rings2 = new System.Windows.Forms.ComboBox();
            this.rings1 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Lweapon1 = new System.Windows.Forms.ComboBox();
            this.Soulpage = new System.Windows.Forms.TabPage();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.clvl = new System.Windows.Forms.Label();
            this.Currentlvl = new System.Windows.Forms.TextBox();
            this.Settings = new System.Windows.Forms.TabPage();
            this.Settingsapply = new System.Windows.Forms.Button();
            this.combobox7 = new System.Windows.Forms.ComboBox();
            this.Themelbl = new System.Windows.Forms.Label();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.Languagelbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LightThemebut = new System.Windows.Forms.Button();
            this.DarkThemebut = new System.Windows.Forms.Button();
            this.About.SuspendLayout();
            this.Vitpage.SuspendLayout();
            this.Soulpage.SuspendLayout();
            this.Settings.SuspendLayout();
            this.SuspendLayout();
            // 
            // About
            // 
            this.About.Controls.Add(this.Vitpage);
            this.About.Controls.Add(this.Soulpage);
            this.About.Controls.Add(this.Settings);
            resources.ApplyResources(this.About, "About");
            this.About.Name = "About";
            this.About.SelectedIndex = 0;
            this.About.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            // 
            // Vitpage
            // 
            this.Vitpage.BackColor = System.Drawing.Color.White;
            this.Vitpage.BackgroundImage = global::DarkSoulsStatCalc.Properties.Resources.Vitlight;
            this.Vitpage.Controls.Add(this.Aboutlink);
            this.Vitpage.Controls.Add(this.comboBox13);
            this.Vitpage.Controls.Add(this.comboBox12);
            this.Vitpage.Controls.Add(this.comboBox11);
            this.Vitpage.Controls.Add(this.comboBox10);
            this.Vitpage.Controls.Add(this.rings4);
            this.Vitpage.Controls.Add(this.rings3);
            this.Vitpage.Controls.Add(this.rings2);
            this.Vitpage.Controls.Add(this.rings1);
            this.Vitpage.Controls.Add(this.comboBox5);
            this.Vitpage.Controls.Add(this.comboBox4);
            this.Vitpage.Controls.Add(this.comboBox3);
            this.Vitpage.Controls.Add(this.comboBox2);
            this.Vitpage.Controls.Add(this.comboBox1);
            this.Vitpage.Controls.Add(this.Lweapon1);
            resources.ApplyResources(this.Vitpage, "Vitpage");
            this.Vitpage.Name = "Vitpage";
            this.Vitpage.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // Aboutlink
            // 
            resources.ApplyResources(this.Aboutlink, "Aboutlink");
            this.Aboutlink.BackColor = System.Drawing.Color.Transparent;
            this.Aboutlink.LinkColor = System.Drawing.Color.Orange;
            this.Aboutlink.Name = "Aboutlink";
            this.Aboutlink.TabStop = true;
            this.Aboutlink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // comboBox13
            // 
            this.comboBox13.FormattingEnabled = true;
            resources.ApplyResources(this.comboBox13, "comboBox13");
            this.comboBox13.Name = "comboBox13";
            // 
            // comboBox12
            // 
            this.comboBox12.FormattingEnabled = true;
            resources.ApplyResources(this.comboBox12, "comboBox12");
            this.comboBox12.Name = "comboBox12";
            // 
            // comboBox11
            // 
            this.comboBox11.FormattingEnabled = true;
            resources.ApplyResources(this.comboBox11, "comboBox11");
            this.comboBox11.Name = "comboBox11";
            // 
            // comboBox10
            // 
            this.comboBox10.FormattingEnabled = true;
            resources.ApplyResources(this.comboBox10, "comboBox10");
            this.comboBox10.Name = "comboBox10";
            // 
            // rings4
            // 
            this.rings4.FormattingEnabled = true;
            resources.ApplyResources(this.rings4, "rings4");
            this.rings4.Name = "rings4";
            // 
            // rings3
            // 
            this.rings3.FormattingEnabled = true;
            resources.ApplyResources(this.rings3, "rings3");
            this.rings3.Name = "rings3";
            // 
            // rings2
            // 
            this.rings2.FormattingEnabled = true;
            resources.ApplyResources(this.rings2, "rings2");
            this.rings2.Name = "rings2";
            // 
            // rings1
            // 
            this.rings1.FormattingEnabled = true;
            resources.ApplyResources(this.rings1, "rings1");
            this.rings1.Name = "rings1";
            this.rings1.SelectedIndexChanged += new System.EventHandler(this.comboBox6_SelectedIndexChanged);
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            resources.ApplyResources(this.comboBox5, "comboBox5");
            this.comboBox5.Name = "comboBox5";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            resources.ApplyResources(this.comboBox4, "comboBox4");
            this.comboBox4.Name = "comboBox4";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            resources.ApplyResources(this.comboBox3, "comboBox3");
            this.comboBox3.Name = "comboBox3";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            resources.ApplyResources(this.comboBox2, "comboBox2");
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.Name = "comboBox1";
            // 
            // Lweapon1
            // 
            this.Lweapon1.FormattingEnabled = true;
            resources.ApplyResources(this.Lweapon1, "Lweapon1");
            this.Lweapon1.Name = "Lweapon1";
            this.Lweapon1.SelectedIndexChanged += new System.EventHandler(this.Lweapon1_SelectedIndexChanged);
            // 
            // Soulpage
            // 
            this.Soulpage.Controls.Add(this.linkLabel1);
            this.Soulpage.Controls.Add(this.clvl);
            this.Soulpage.Controls.Add(this.Currentlvl);
            resources.ApplyResources(this.Soulpage, "Soulpage");
            this.Soulpage.Name = "Soulpage";
            this.Soulpage.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            resources.ApplyResources(this.linkLabel1, "linkLabel1");
            this.linkLabel1.LinkColor = System.Drawing.Color.Orange;
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.TabStop = true;
            // 
            // clvl
            // 
            resources.ApplyResources(this.clvl, "clvl");
            this.clvl.Name = "clvl";
            // 
            // Currentlvl
            // 
            resources.ApplyResources(this.Currentlvl, "Currentlvl");
            this.Currentlvl.Name = "Currentlvl";
            // 
            // Settings
            // 
            this.Settings.BackColor = System.Drawing.Color.White;
            this.Settings.Controls.Add(this.DarkThemebut);
            this.Settings.Controls.Add(this.LightThemebut);
            this.Settings.Controls.Add(this.Settingsapply);
            this.Settings.Controls.Add(this.combobox7);
            this.Settings.Controls.Add(this.Themelbl);
            this.Settings.Controls.Add(this.comboBox6);
            this.Settings.Controls.Add(this.Languagelbl);
            this.Settings.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.Settings, "Settings");
            this.Settings.Name = "Settings";
            this.Settings.Click += new System.EventHandler(this.tabPage1_Click_1);
            // 
            // Settingsapply
            // 
            resources.ApplyResources(this.Settingsapply, "Settingsapply");
            this.Settingsapply.Name = "Settingsapply";
            this.Settingsapply.UseVisualStyleBackColor = true;
            this.Settingsapply.Click += new System.EventHandler(this.Settingsapply_Click);
            // 
            // combobox7
            // 
            this.combobox7.FormattingEnabled = true;
            this.combobox7.Items.AddRange(new object[] {
            resources.GetString("combobox7.Items"),
            resources.GetString("combobox7.Items1")});
            resources.ApplyResources(this.combobox7, "combobox7");
            this.combobox7.Name = "combobox7";
            // 
            // Themelbl
            // 
            resources.ApplyResources(this.Themelbl, "Themelbl");
            this.Themelbl.Name = "Themelbl";
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
            resources.GetString("comboBox6.Items"),
            resources.GetString("comboBox6.Items1")});
            resources.ApplyResources(this.comboBox6, "comboBox6");
            this.comboBox6.Name = "comboBox6";
            // 
            // Languagelbl
            // 
            resources.ApplyResources(this.Languagelbl, "Languagelbl");
            this.Languagelbl.Name = "Languagelbl";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LightThemebut
            // 
            resources.ApplyResources(this.LightThemebut, "LightThemebut");
            this.LightThemebut.Name = "LightThemebut";
            this.LightThemebut.UseVisualStyleBackColor = true;
            this.LightThemebut.Click += new System.EventHandler(this.LightThemebut_Click);
            // 
            // DarkThemebut
            // 
            resources.ApplyResources(this.DarkThemebut, "DarkThemebut");
            this.DarkThemebut.Name = "DarkThemebut";
            this.DarkThemebut.UseVisualStyleBackColor = true;
            this.DarkThemebut.Click += new System.EventHandler(this.DarkThemebut_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.About);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.About.ResumeLayout(false);
            this.Vitpage.ResumeLayout(false);
            this.Vitpage.PerformLayout();
            this.Soulpage.ResumeLayout(false);
            this.Soulpage.PerformLayout();
            this.Settings.ResumeLayout(false);
            this.Settings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl About;
        private System.Windows.Forms.TabPage Vitpage;
        private System.Windows.Forms.TabPage Soulpage;
        private System.Windows.Forms.ComboBox Lweapon1;
        private System.Windows.Forms.Label clvl;
        private System.Windows.Forms.TextBox Currentlvl;
        private System.Windows.Forms.ComboBox comboBox13;
        private System.Windows.Forms.ComboBox comboBox12;
        private System.Windows.Forms.ComboBox comboBox11;
        private System.Windows.Forms.ComboBox comboBox10;
        private System.Windows.Forms.ComboBox rings4;
        private System.Windows.Forms.ComboBox rings3;
        private System.Windows.Forms.ComboBox rings2;
        private System.Windows.Forms.ComboBox rings1;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.LinkLabel Aboutlink;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TabPage Settings;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.Label Languagelbl;
        private System.Windows.Forms.ComboBox combobox7;
        private System.Windows.Forms.Label Themelbl;
        private System.Windows.Forms.Button Settingsapply;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button DarkThemebut;
        private System.Windows.Forms.Button LightThemebut;
    }
}

