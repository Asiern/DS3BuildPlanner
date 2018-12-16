namespace DarkSoulsStatCalc
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.Currentlvl = new System.Windows.Forms.TextBox();
            this.clvl = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.vitalityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soulsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Currentlvl
            // 
            this.Currentlvl.Location = new System.Drawing.Point(181, 86);
            this.Currentlvl.Name = "Currentlvl";
            this.Currentlvl.Size = new System.Drawing.Size(199, 20);
            this.Currentlvl.TabIndex = 0;
            // 
            // clvl
            // 
            this.clvl.AutoSize = true;
            this.clvl.Location = new System.Drawing.Point(88, 89);
            this.clvl.Name = "clvl";
            this.clvl.Size = new System.Drawing.Size(70, 13);
            this.clvl.TabIndex = 1;
            this.clvl.Text = "Current Level";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vitalityToolStripMenuItem,
            this.soulsToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(587, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // vitalityToolStripMenuItem
            // 
            this.vitalityToolStripMenuItem.Name = "vitalityToolStripMenuItem";
            this.vitalityToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.vitalityToolStripMenuItem.Text = "Vitality";
            this.vitalityToolStripMenuItem.Click += new System.EventHandler(this.vitalityToolStripMenuItem_Click);
            // 
            // soulsToolStripMenuItem
            // 
            this.soulsToolStripMenuItem.Name = "soulsToolStripMenuItem";
            this.soulsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.soulsToolStripMenuItem.Text = "Souls";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 587);
            this.Controls.Add(this.clvl);
            this.Controls.Add(this.Currentlvl);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Souls";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Currentlvl;
        private System.Windows.Forms.Label clvl;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem vitalityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soulsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}