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
            this.testcb = new MaterialSkin.Controls.MaterialComboBox();
            this.FatRollbtn = new MaterialSkin.Controls.MaterialRadioButton();
            this.MediumRollbtn = new MaterialSkin.Controls.MaterialRadioButton();
            this.FastRollbtn = new MaterialSkin.Controls.MaterialRadioButton();
            this.calculatebtn = new MaterialSkin.Controls.MaterialButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl2 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.materialComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            this.materialSwitch1 = new MaterialSkin.Controls.MaterialSwitch();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.Info = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.materialTabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.Info.SuspendLayout();
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
            this.materialTabControl2.Controls.Add(this.tabPage5);
            this.materialTabControl2.Controls.Add(this.Info);
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
            // Info
            // 
            this.Info.Controls.Add(this.materialTextBox1);
            this.Info.Controls.Add(this.materialButton2);
            this.Info.Controls.Add(this.comboBox2);
            this.Info.Location = new System.Drawing.Point(4, 22);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(952, 521);
            this.Info.TabIndex = 3;
            this.Info.Text = "Info";
            this.Info.UseVisualStyleBackColor = true;
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(161, 179);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(188, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(87, 96);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(178, 21);
            this.comboBox2.TabIndex = 0;
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Depth = 0;
            this.materialButton2.DrawShadows = true;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(559, 251);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.Size = new System.Drawing.Size(158, 36);
            this.materialButton2.TabIndex = 1;
            this.materialButton2.Text = "materialButton2";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // materialTextBox1
            // 
            this.materialTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox1.Depth = 0;
            this.materialTextBox1.Font = new System.Drawing.Font("Roboto", 12F);
            this.materialTextBox1.Location = new System.Drawing.Point(64, 251);
            this.materialTextBox1.MaxLength = 50;
            this.materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox1.Multiline = false;
            this.materialTextBox1.Name = "materialTextBox1";
            this.materialTextBox1.Size = new System.Drawing.Size(466, 50);
            this.materialTextBox1.TabIndex = 2;
            this.materialTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 610);
            this.Controls.Add(this.materialTabControl2);
            this.DrawerTabControl = this.materialTabControl2;
            this.Name = "Form1";
            this.Text = "DS3 Build Planner";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.materialTabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.Info.ResumeLayout(false);
            this.Info.PerformLayout();
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
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
    }
}

