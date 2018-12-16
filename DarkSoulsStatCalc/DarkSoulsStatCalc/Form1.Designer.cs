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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Calculate = new System.Windows.Forms.Button();
            this.Rweapon1 = new System.Windows.Forms.ComboBox();
            this.Armorlbl = new System.Windows.Forms.Label();
            this.Lweapon1 = new System.Windows.Forms.ComboBox();
            this.Ring1 = new System.Windows.Forms.ComboBox();
            this.Ring2 = new System.Windows.Forms.ComboBox();
            this.Rweapon2 = new System.Windows.Forms.ComboBox();
            this.Rweapon3 = new System.Windows.Forms.ComboBox();
            this.Lweapon2 = new System.Windows.Forms.ComboBox();
            this.Lweapon3 = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.Ringslbl = new System.Windows.Forms.Label();
            this.Ring3 = new System.Windows.Forms.ComboBox();
            this.Ring4 = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.comboBox11 = new System.Windows.Forms.ComboBox();
            this.comboBox12 = new System.Windows.Forms.ComboBox();
            this.armor = new System.Windows.Forms.Label();
            this.comboBox13 = new System.Windows.Forms.ComboBox();
            this.comboBox14 = new System.Windows.Forms.ComboBox();
            this.soulsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(31, 463);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(85, 27);
            this.Calculate.TabIndex = 0;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            // 
            // Rweapon1
            // 
            this.Rweapon1.FormattingEnabled = true;
            this.Rweapon1.Location = new System.Drawing.Point(121, 62);
            this.Rweapon1.Name = "Rweapon1";
            this.Rweapon1.Size = new System.Drawing.Size(178, 21);
            this.Rweapon1.TabIndex = 1;
            this.Rweapon1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Armorlbl
            // 
            this.Armorlbl.AutoSize = true;
            this.Armorlbl.Location = new System.Drawing.Point(42, 65);
            this.Armorlbl.Name = "Armorlbl";
            this.Armorlbl.Size = new System.Drawing.Size(59, 13);
            this.Armorlbl.TabIndex = 2;
            this.Armorlbl.Text = "R Weapon";
            // 
            // Lweapon1
            // 
            this.Lweapon1.FormattingEnabled = true;
            this.Lweapon1.Location = new System.Drawing.Point(121, 103);
            this.Lweapon1.Name = "Lweapon1";
            this.Lweapon1.Size = new System.Drawing.Size(179, 21);
            this.Lweapon1.TabIndex = 3;
            // 
            // Ring1
            // 
            this.Ring1.FormattingEnabled = true;
            this.Ring1.Location = new System.Drawing.Point(121, 159);
            this.Ring1.Name = "Ring1";
            this.Ring1.Size = new System.Drawing.Size(125, 21);
            this.Ring1.TabIndex = 4;
            // 
            // Ring2
            // 
            this.Ring2.FormattingEnabled = true;
            this.Ring2.Location = new System.Drawing.Point(262, 159);
            this.Ring2.Name = "Ring2";
            this.Ring2.Size = new System.Drawing.Size(125, 21);
            this.Ring2.TabIndex = 5;
            // 
            // Rweapon2
            // 
            this.Rweapon2.FormattingEnabled = true;
            this.Rweapon2.Location = new System.Drawing.Point(305, 62);
            this.Rweapon2.Name = "Rweapon2";
            this.Rweapon2.Size = new System.Drawing.Size(178, 21);
            this.Rweapon2.TabIndex = 6;
            // 
            // Rweapon3
            // 
            this.Rweapon3.FormattingEnabled = true;
            this.Rweapon3.Location = new System.Drawing.Point(489, 62);
            this.Rweapon3.Name = "Rweapon3";
            this.Rweapon3.Size = new System.Drawing.Size(178, 21);
            this.Rweapon3.TabIndex = 7;
            // 
            // Lweapon2
            // 
            this.Lweapon2.FormattingEnabled = true;
            this.Lweapon2.Location = new System.Drawing.Point(305, 103);
            this.Lweapon2.Name = "Lweapon2";
            this.Lweapon2.Size = new System.Drawing.Size(178, 21);
            this.Lweapon2.TabIndex = 8;
            // 
            // Lweapon3
            // 
            this.Lweapon3.FormattingEnabled = true;
            this.Lweapon3.Location = new System.Drawing.Point(489, 103);
            this.Lweapon3.Name = "Lweapon3";
            this.Lweapon3.Size = new System.Drawing.Size(178, 21);
            this.Lweapon3.TabIndex = 9;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.soulsToolStripMenuItem,
            this.aboutToolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(681, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Checked = true;
            this.aboutToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.aboutToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.aboutToolStripMenuItem.Text = "Vitality ";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "L Weapon";
            // 
            // Ringslbl
            // 
            this.Ringslbl.AutoSize = true;
            this.Ringslbl.Location = new System.Drawing.Point(42, 162);
            this.Ringslbl.Name = "Ringslbl";
            this.Ringslbl.Size = new System.Drawing.Size(34, 13);
            this.Ringslbl.TabIndex = 13;
            this.Ringslbl.Text = "Rings";
            // 
            // Ring3
            // 
            this.Ring3.FormattingEnabled = true;
            this.Ring3.Location = new System.Drawing.Point(411, 159);
            this.Ring3.Name = "Ring3";
            this.Ring3.Size = new System.Drawing.Size(125, 21);
            this.Ring3.TabIndex = 14;
            // 
            // Ring4
            // 
            this.Ring4.FormattingEnabled = true;
            this.Ring4.Location = new System.Drawing.Point(542, 159);
            this.Ring4.Name = "Ring4";
            this.Ring4.Size = new System.Drawing.Size(125, 21);
            this.Ring4.TabIndex = 15;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(37, 313);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(62, 17);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.Text = "Fast roll";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(37, 355);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(79, 17);
            this.checkBox2.TabIndex = 17;
            this.checkBox2.Text = "Regular roll";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(37, 396);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(65, 17);
            this.checkBox3.TabIndex = 18;
            this.checkBox3.Text = "Slow roll";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // comboBox11
            // 
            this.comboBox11.FormattingEnabled = true;
            this.comboBox11.Location = new System.Drawing.Point(338, 353);
            this.comboBox11.Name = "comboBox11";
            this.comboBox11.Size = new System.Drawing.Size(138, 21);
            this.comboBox11.TabIndex = 23;
            // 
            // comboBox12
            // 
            this.comboBox12.FormattingEnabled = true;
            this.comboBox12.Location = new System.Drawing.Point(162, 353);
            this.comboBox12.Name = "comboBox12";
            this.comboBox12.Size = new System.Drawing.Size(138, 21);
            this.comboBox12.TabIndex = 22;
            // 
            // armor
            // 
            this.armor.AutoSize = true;
            this.armor.Location = new System.Drawing.Point(161, 297);
            this.armor.Name = "armor";
            this.armor.Size = new System.Drawing.Size(34, 13);
            this.armor.TabIndex = 21;
            this.armor.Text = "Armor";
            // 
            // comboBox13
            // 
            this.comboBox13.FormattingEnabled = true;
            this.comboBox13.Location = new System.Drawing.Point(338, 313);
            this.comboBox13.Name = "comboBox13";
            this.comboBox13.Size = new System.Drawing.Size(138, 21);
            this.comboBox13.TabIndex = 20;
            // 
            // comboBox14
            // 
            this.comboBox14.FormattingEnabled = true;
            this.comboBox14.Location = new System.Drawing.Point(162, 313);
            this.comboBox14.Name = "comboBox14";
            this.comboBox14.Size = new System.Drawing.Size(138, 21);
            this.comboBox14.TabIndex = 19;
            // 
            // soulsToolStripMenuItem
            // 
            this.soulsToolStripMenuItem.Name = "soulsToolStripMenuItem";
            this.soulsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.soulsToolStripMenuItem.Text = "Souls";
            this.soulsToolStripMenuItem.Click += new System.EventHandler(this.soulsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 523);
            this.Controls.Add(this.comboBox11);
            this.Controls.Add(this.comboBox12);
            this.Controls.Add(this.armor);
            this.Controls.Add(this.comboBox13);
            this.Controls.Add(this.comboBox14);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Ring4);
            this.Controls.Add(this.Ring3);
            this.Controls.Add(this.Ringslbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Lweapon3);
            this.Controls.Add(this.Lweapon2);
            this.Controls.Add(this.Rweapon3);
            this.Controls.Add(this.Rweapon2);
            this.Controls.Add(this.Ring2);
            this.Controls.Add(this.Ring1);
            this.Controls.Add(this.Lweapon1);
            this.Controls.Add(this.Armorlbl);
            this.Controls.Add(this.Rweapon1);
            this.Controls.Add(this.Calculate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Dark Souls Stat Calc";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.ComboBox Rweapon1;
        private System.Windows.Forms.Label Armorlbl;
        private System.Windows.Forms.ComboBox Lweapon1;
        private System.Windows.Forms.ComboBox Ring1;
        private System.Windows.Forms.ComboBox Ring2;
        private System.Windows.Forms.ComboBox Rweapon2;
        private System.Windows.Forms.ComboBox Rweapon3;
        private System.Windows.Forms.ComboBox Lweapon2;
        private System.Windows.Forms.ComboBox Lweapon3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Ringslbl;
        private System.Windows.Forms.ComboBox Ring3;
        private System.Windows.Forms.ComboBox Ring4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.ComboBox comboBox11;
        private System.Windows.Forms.ComboBox comboBox12;
        private System.Windows.Forms.Label armor;
        private System.Windows.Forms.ComboBox comboBox13;
        private System.Windows.Forms.ComboBox comboBox14;
        private System.Windows.Forms.ToolStripMenuItem soulsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

