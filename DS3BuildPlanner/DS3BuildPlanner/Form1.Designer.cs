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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.calculatebtn = new MaterialSkin.Controls.MaterialButton();
            this.FastRollbtn = new MaterialSkin.Controls.MaterialRadioButton();
            this.MediumRollbtn = new MaterialSkin.Controls.MaterialRadioButton();
            this.FatRollbtn = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialDrawer1 = new MaterialSkin.Controls.MaterialDrawer();
            this.materialTabControl2 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.materialTabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(219, 90);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(244, 352);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.FatRollbtn);
            this.tabPage1.Controls.Add(this.MediumRollbtn);
            this.tabPage1.Controls.Add(this.FastRollbtn);
            this.tabPage1.Controls.Add(this.calculatebtn);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(236, 326);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Vitality";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(859, 463);
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
            this.materialTabSelector1.Size = new System.Drawing.Size(773, 39);
            this.materialTabSelector1.TabIndex = 1;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // calculatebtn
            // 
            this.calculatebtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.calculatebtn.Depth = 0;
            this.calculatebtn.DrawShadows = true;
            this.calculatebtn.HighEmphasis = true;
            this.calculatebtn.Icon = null;
            this.calculatebtn.Location = new System.Drawing.Point(88, 258);
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
            // FastRollbtn
            // 
            this.FastRollbtn.AutoSize = true;
            this.FastRollbtn.Depth = 0;
            this.FastRollbtn.Location = new System.Drawing.Point(48, 74);
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
            // MediumRollbtn
            // 
            this.MediumRollbtn.AutoSize = true;
            this.MediumRollbtn.Depth = 0;
            this.MediumRollbtn.Location = new System.Drawing.Point(48, 122);
            this.MediumRollbtn.Margin = new System.Windows.Forms.Padding(0);
            this.MediumRollbtn.MouseLocation = new System.Drawing.Point(-1, -1);
            this.MediumRollbtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.MediumRollbtn.Name = "MediumRollbtn";
            this.MediumRollbtn.Ripple = true;
            this.MediumRollbtn.Size = new System.Drawing.Size(143, 37);
            this.MediumRollbtn.TabIndex = 2;
            this.MediumRollbtn.TabStop = true;
            this.MediumRollbtn.Text = "MediumRollbtn";
            this.MediumRollbtn.UseVisualStyleBackColor = true;
            // 
            // FatRollbtn
            // 
            this.FatRollbtn.AutoSize = true;
            this.FatRollbtn.Depth = 0;
            this.FatRollbtn.Location = new System.Drawing.Point(48, 179);
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
            // materialDrawer1
            // 
            this.materialDrawer1.AutoHide = false;
            this.materialDrawer1.BackgroundWithAccent = false;
            this.materialDrawer1.BaseTabControl = this.materialTabControl2;
            this.materialDrawer1.Depth = 0;
            this.materialDrawer1.HighlightWithAccent = true;
            this.materialDrawer1.IndicatorWidth = 0;
            this.materialDrawer1.IsOpen = true;
            this.materialDrawer1.Location = new System.Drawing.Point(0, 64);
            this.materialDrawer1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDrawer1.Name = "materialDrawer1";
            this.materialDrawer1.ShowIconsWhenHidden = false;
            this.materialDrawer1.Size = new System.Drawing.Size(146, 548);
            this.materialDrawer1.TabIndex = 2;
            this.materialDrawer1.Text = "materialDrawer1";
            this.materialDrawer1.UseColors = false;
            // 
            // materialTabControl2
            // 
            this.materialTabControl2.Controls.Add(this.tabPage3);
            this.materialTabControl2.Controls.Add(this.tabPage4);
            this.materialTabControl2.Depth = 0;
            this.materialTabControl2.Location = new System.Drawing.Point(152, 64);
            this.materialTabControl2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl2.Name = "materialTabControl2";
            this.materialTabControl2.SelectedIndex = 0;
            this.materialTabControl2.Size = new System.Drawing.Size(802, 534);
            this.materialTabControl2.TabIndex = 3;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.materialTabSelector1);
            this.tabPage3.Controls.Add(this.materialTabControl1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(794, 508);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Calculator";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(794, 508);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "About";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 610);
            this.Controls.Add(this.materialDrawer1);
            this.Controls.Add(this.materialTabControl2);
            this.Name = "Form1";
            this.Text = "DS3 Build Planner";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.materialTabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
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
        private MaterialSkin.Controls.MaterialDrawer materialDrawer1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
    }
}

