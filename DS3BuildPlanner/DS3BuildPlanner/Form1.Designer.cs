namespace DS3BuildPlanner
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.testcb = new MaterialSkin.Controls.MaterialComboBox();
            this.FatRollbtn = new MaterialSkin.Controls.MaterialRadioButton();
            this.MediumRollbtn = new MaterialSkin.Controls.MaterialRadioButton();
            this.FastRollbtn = new MaterialSkin.Controls.MaterialRadioButton();
            this.calculatebtn = new MaterialSkin.Controls.MaterialButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl2 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Info = new System.Windows.Forms.TabPage();
            this.materialListView1 = new MaterialSkin.Controls.MaterialListView();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.materialComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            this.materialSwitch1 = new MaterialSkin.Controls.MaterialSwitch();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PhysicalAbsortion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MagicAbsortion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FireAbsortion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialTabControl3 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.materialTabSelector2 = new MaterialSkin.Controls.MaterialTabSelector();
            this.LightningAbsortion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DarkAbsortion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BleedResistance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PoisonResistance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FrostResistance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CurseResistance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Poise = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Weight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PoiseWeightRatio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.materialTabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.Info.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.materialTabControl3.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(10, 45);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(928, 463);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.testcb);
            this.tabPage1.Controls.Add(this.FatRollbtn);
            this.tabPage1.Controls.Add(this.MediumRollbtn);
            this.tabPage1.Controls.Add(this.FastRollbtn);
            this.tabPage1.Controls.Add(this.calculatebtn);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(920, 437);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Vitality";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(161, 179);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(188, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // testcb
            // 
            this.testcb.AutoResize = false;
            this.testcb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.testcb.Depth = 0;
            this.testcb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.testcb.DropDownHeight = 174;
            this.testcb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.testcb.DropDownWidth = 121;
            this.testcb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.testcb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.testcb.FormattingEnabled = true;
            this.testcb.IntegralHeight = false;
            this.testcb.ItemHeight = 43;
            this.testcb.Location = new System.Drawing.Point(161, 66);
            this.testcb.MaxDropDownItems = 4;
            this.testcb.MouseState = MaterialSkin.MouseState.OUT;
            this.testcb.Name = "testcb";
            this.testcb.Size = new System.Drawing.Size(260, 49);
            this.testcb.TabIndex = 4;
            // 
            // FatRollbtn
            // 
            this.FatRollbtn.AutoSize = true;
            this.FatRollbtn.Depth = 0;
            this.FatRollbtn.Location = new System.Drawing.Point(761, 300);
            this.FatRollbtn.Margin = new System.Windows.Forms.Padding(0);
            this.FatRollbtn.MouseLocation = new System.Drawing.Point(-1, -1);
            this.FatRollbtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.FatRollbtn.Name = "FatRollbtn";
            this.FatRollbtn.Ripple = true;
            this.FatRollbtn.Size = new System.Drawing.Size(89, 37);
            this.FatRollbtn.TabIndex = 3;
            this.FatRollbtn.TabStop = true;
            this.FatRollbtn.Text = "Fat Roll";
            this.FatRollbtn.UseVisualStyleBackColor = true;
            // 
            // MediumRollbtn
            // 
            this.MediumRollbtn.AutoSize = true;
            this.MediumRollbtn.Depth = 0;
            this.MediumRollbtn.Location = new System.Drawing.Point(761, 250);
            this.MediumRollbtn.Margin = new System.Windows.Forms.Padding(0);
            this.MediumRollbtn.MouseLocation = new System.Drawing.Point(-1, -1);
            this.MediumRollbtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.MediumRollbtn.Name = "MediumRollbtn";
            this.MediumRollbtn.Ripple = true;
            this.MediumRollbtn.Size = new System.Drawing.Size(124, 37);
            this.MediumRollbtn.TabIndex = 2;
            this.MediumRollbtn.TabStop = true;
            this.MediumRollbtn.Text = "Medium Roll";
            this.MediumRollbtn.UseVisualStyleBackColor = true;
            // 
            // FastRollbtn
            // 
            this.FastRollbtn.AutoSize = true;
            this.FastRollbtn.Depth = 0;
            this.FastRollbtn.Location = new System.Drawing.Point(761, 202);
            this.FastRollbtn.Margin = new System.Windows.Forms.Padding(0);
            this.FastRollbtn.MouseLocation = new System.Drawing.Point(-1, -1);
            this.FastRollbtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.FastRollbtn.Name = "FastRollbtn";
            this.FastRollbtn.Ripple = true;
            this.FastRollbtn.Size = new System.Drawing.Size(97, 37);
            this.FastRollbtn.TabIndex = 1;
            this.FastRollbtn.TabStop = true;
            this.FastRollbtn.Text = "Fast Roll";
            this.FastRollbtn.UseVisualStyleBackColor = true;
            // 
            // calculatebtn
            // 
            this.calculatebtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.calculatebtn.Depth = 0;
            this.calculatebtn.DrawShadows = true;
            this.calculatebtn.HighEmphasis = true;
            this.calculatebtn.Icon = null;
            this.calculatebtn.Location = new System.Drawing.Point(761, 360);
            this.calculatebtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.calculatebtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.calculatebtn.Name = "calculatebtn";
            this.calculatebtn.Size = new System.Drawing.Size(103, 36);
            this.calculatebtn.TabIndex = 0;
            this.calculatebtn.Text = "Calculate";
            this.calculatebtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.calculatebtn.UseAccentColor = false;
            this.calculatebtn.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(920, 437);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Souls";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 0);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(952, 39);
            this.materialTabSelector1.TabIndex = 1;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // materialTabControl2
            // 
            this.materialTabControl2.Controls.Add(this.tabPage3);
            this.materialTabControl2.Controls.Add(this.Info);
            this.materialTabControl2.Controls.Add(this.tabPage5);
            this.materialTabControl2.Controls.Add(this.tabPage4);
            this.materialTabControl2.Depth = 0;
            this.materialTabControl2.Location = new System.Drawing.Point(-2, 64);
            this.materialTabControl2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl2.Name = "materialTabControl2";
            this.materialTabControl2.SelectedIndex = 0;
            this.materialTabControl2.Size = new System.Drawing.Size(960, 547);
            this.materialTabControl2.TabIndex = 3;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.materialTabSelector1);
            this.tabPage3.Controls.Add(this.materialTabControl1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(952, 521);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Calculator";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Info
            // 
            this.Info.Controls.Add(this.materialTabSelector2);
            this.Info.Controls.Add(this.materialTabControl3);
            this.Info.Location = new System.Drawing.Point(4, 22);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(952, 521);
            this.Info.TabIndex = 3;
            this.Info.Text = "Item Stats";
            this.Info.UseVisualStyleBackColor = true;
            // 
            // materialListView1
            // 
            this.materialListView1.AutoSizeTable = true;
            this.materialListView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name,
            this.PhysicalAbsortion,
            this.MagicAbsortion,
            this.FireAbsortion,
            this.LightningAbsortion,
            this.DarkAbsortion,
            this.BleedResistance,
            this.PoisonResistance,
            this.FrostResistance,
            this.CurseResistance,
            this.Poise,
            this.Weight,
            this.PoiseWeightRatio});
            this.materialListView1.Depth = 0;
            this.materialListView1.FullRowSelect = true;
            this.materialListView1.HideSelection = false;
            this.materialListView1.Location = new System.Drawing.Point(23, 109);
            this.materialListView1.MinimumSize = new System.Drawing.Size(200, 100);
            this.materialListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView1.Name = "materialListView1";
            this.materialListView1.OwnerDraw = true;
            this.materialListView1.Scrollable = false;
            this.materialListView1.Size = new System.Drawing.Size(825, 100);
            this.materialListView1.TabIndex = 2;
            this.materialListView1.UseCompatibleStateImageBehavior = false;
            this.materialListView1.View = System.Windows.Forms.View.Details;
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Depth = 0;
            this.materialButton2.DrawShadows = true;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(528, 320);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.Size = new System.Drawing.Size(59, 36);
            this.materialButton2.TabIndex = 1;
            this.materialButton2.Text = "LOAD";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(116, 48);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(178, 21);
            this.comboBox2.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.materialComboBox1);
            this.tabPage5.Controls.Add(this.materialSwitch1);
            this.tabPage5.Controls.Add(this.materialButton1);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(952, 521);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "Theme";
            this.tabPage5.UseVisualStyleBackColor = true;
            this.tabPage5.Click += new System.EventHandler(this.tabPage5_Click);
            // 
            // materialComboBox1
            // 
            this.materialComboBox1.AutoResize = false;
            this.materialComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBox1.Depth = 0;
            this.materialComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox1.DropDownHeight = 174;
            this.materialComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox1.DropDownWidth = 121;
            this.materialComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox1.FormattingEnabled = true;
            this.materialComboBox1.IntegralHeight = false;
            this.materialComboBox1.ItemHeight = 43;
            this.materialComboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.materialComboBox1.Location = new System.Drawing.Point(176, 116);
            this.materialComboBox1.MaxDropDownItems = 4;
            this.materialComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox1.Name = "materialComboBox1";
            this.materialComboBox1.Size = new System.Drawing.Size(121, 49);
            this.materialComboBox1.TabIndex = 2;
            this.materialComboBox1.SelectedIndexChanged += new System.EventHandler(this.materialComboBox1_SelectedIndexChanged);
            this.materialComboBox1.TabIndexChanged += new System.EventHandler(this.materialComboBox1_TabIndexChanged);
            // 
            // materialSwitch1
            // 
            this.materialSwitch1.AutoSize = true;
            this.materialSwitch1.Depth = 0;
            this.materialSwitch1.Location = new System.Drawing.Point(733, 328);
            this.materialSwitch1.Margin = new System.Windows.Forms.Padding(0);
            this.materialSwitch1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialSwitch1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSwitch1.Name = "materialSwitch1";
            this.materialSwitch1.Ripple = true;
            this.materialSwitch1.Size = new System.Drawing.Size(140, 37);
            this.materialSwitch1.TabIndex = 1;
            this.materialSwitch1.Text = "DarkTheme";
            this.materialSwitch1.UseVisualStyleBackColor = true;
            this.materialSwitch1.CheckedChanged += new System.EventHandler(this.materialSwitch1_CheckedChanged);
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Depth = 0;
            this.materialButton1.DrawShadows = true;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(733, 416);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.Size = new System.Drawing.Size(58, 36);
            this.materialButton1.TabIndex = 0;
            this.materialButton1.Text = "Save";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(952, 521);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "About";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // Name
            // 
            this.Name.Text = "Name";
            this.Name.Width = 110;
            // 
            // PhysicalAbsortion
            // 
            this.PhysicalAbsortion.Text = "P";
            this.PhysicalAbsortion.Width = 45;
            // 
            // MagicAbsortion
            // 
            this.MagicAbsortion.Text = "M";
            // 
            // FireAbsortion
            // 
            this.FireAbsortion.Text = "F";
            // 
            // materialTabControl3
            // 
            this.materialTabControl3.Controls.Add(this.tabPage6);
            this.materialTabControl3.Controls.Add(this.tabPage7);
            this.materialTabControl3.Depth = 0;
            this.materialTabControl3.Location = new System.Drawing.Point(10, 45);
            this.materialTabControl3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl3.Name = "materialTabControl3";
            this.materialTabControl3.SelectedIndex = 0;
            this.materialTabControl3.Size = new System.Drawing.Size(928, 467);
            this.materialTabControl3.TabIndex = 3;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.materialButton2);
            this.tabPage6.Controls.Add(this.materialListView1);
            this.tabPage6.Controls.Add(this.comboBox2);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(920, 441);
            this.tabPage6.TabIndex = 0;
            this.tabPage6.Text = "Armor";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(920, 412);
            this.tabPage7.TabIndex = 1;
            this.tabPage7.Text = "Rings";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // materialTabSelector2
            // 
            this.materialTabSelector2.BaseTabControl = this.materialTabControl3;
            this.materialTabSelector2.Depth = 0;
            this.materialTabSelector2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTabSelector2.Location = new System.Drawing.Point(-4, 0);
            this.materialTabSelector2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector2.Name = "materialTabSelector2";
            this.materialTabSelector2.Size = new System.Drawing.Size(953, 39);
            this.materialTabSelector2.TabIndex = 4;
            this.materialTabSelector2.Text = "materialTabSelector2";
            // 
            // LightningAbsortion
            // 
            this.LightningAbsortion.Text = "L";
            // 
            // DarkAbsortion
            // 
            this.DarkAbsortion.Text = "D";
            // 
            // BleedResistance
            // 
            this.BleedResistance.Text = "B";
            this.BleedResistance.Width = 70;
            // 
            // PoisonResistance
            // 
            this.PoisonResistance.Text = "Po";
            // 
            // FrostResistance
            // 
            this.FrostResistance.Text = "Fr";
            // 
            // CurseResistance
            // 
            this.CurseResistance.Text = "Cu";
            // 
            // Poise
            // 
            this.Poise.Text = "Poise";
            // 
            // Weight
            // 
            this.Weight.Text = "W";
            // 
            // PoiseWeightRatio
            // 
            this.PoiseWeightRatio.Text = "P/W";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 610);
            this.Controls.Add(this.materialTabControl2);
            this.DrawerTabControl = this.materialTabControl2;
            this.Text = "DS3 Build Planner";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.materialTabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.Info.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.materialTabControl3.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialButton calculatebtn;
        private MaterialSkin.Controls.MaterialRadioButton FastRollbtn;
        private MaterialSkin.Controls.MaterialRadioButton FatRollbtn;
        private MaterialSkin.Controls.MaterialRadioButton MediumRollbtn;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox1;
        private MaterialSkin.Controls.MaterialSwitch materialSwitch1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialComboBox testcb;
        private System.Windows.Forms.TabPage Info;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialListView materialListView1;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader PhysicalAbsortion;
        private System.Windows.Forms.ColumnHeader MagicAbsortion;
        private System.Windows.Forms.ColumnHeader FireAbsortion;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector2;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl3;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.ColumnHeader LightningAbsortion;
        private System.Windows.Forms.ColumnHeader DarkAbsortion;
        private System.Windows.Forms.ColumnHeader BleedResistance;
        private System.Windows.Forms.ColumnHeader PoisonResistance;
        private System.Windows.Forms.ColumnHeader FrostResistance;
        private System.Windows.Forms.ColumnHeader CurseResistance;
        private System.Windows.Forms.ColumnHeader Poise;
        private System.Windows.Forms.ColumnHeader Weight;
        private System.Windows.Forms.ColumnHeader PoiseWeightRatio;
    }
}

