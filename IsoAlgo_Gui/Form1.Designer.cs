namespace IsoAlgo_Gui
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.but_dest = new System.Windows.Forms.Button();
            this.but_src = new System.Windows.Forms.Button();
            this.lbl_src = new System.Windows.Forms.Label();
            this.lbl_dest = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_src = new System.Windows.Forms.TextBox();
            this.txt_dest = new System.Windows.Forms.TextBox();
            this.but_convert = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // but_dest
            // 
            this.but_dest.Location = new System.Drawing.Point(403, 152);
            this.but_dest.Name = "but_dest";
            this.but_dest.Size = new System.Drawing.Size(27, 20);
            this.but_dest.TabIndex = 0;
            this.but_dest.Text = "...";
            this.but_dest.UseVisualStyleBackColor = true;
            this.but_dest.Click += new System.EventHandler(this.but_dest_Click);
            // 
            // but_src
            // 
            this.but_src.Location = new System.Drawing.Point(403, 93);
            this.but_src.Name = "but_src";
            this.but_src.Size = new System.Drawing.Size(27, 20);
            this.but_src.TabIndex = 1;
            this.but_src.Text = "...";
            this.but_src.UseVisualStyleBackColor = true;
            this.but_src.Click += new System.EventHandler(this.but_src_Click);
            // 
            // lbl_src
            // 
            this.lbl_src.AutoSize = true;
            this.lbl_src.Font = new System.Drawing.Font("Chiller", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_src.Location = new System.Drawing.Point(61, 61);
            this.lbl_src.Name = "lbl_src";
            this.lbl_src.Size = new System.Drawing.Size(62, 31);
            this.lbl_src.TabIndex = 3;
            this.lbl_src.Text = "Input";
            this.lbl_src.Click += new System.EventHandler(this.lbl_src_Click);
            // 
            // lbl_dest
            // 
            this.lbl_dest.AutoSize = true;
            this.lbl_dest.Font = new System.Drawing.Font("Chiller", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dest.Location = new System.Drawing.Point(61, 120);
            this.lbl_dest.Name = "lbl_dest";
            this.lbl_dest.Size = new System.Drawing.Size(74, 31);
            this.lbl_dest.TabIndex = 4;
            this.lbl_dest.Text = "Output";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(490, 39);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.dateiToolStripMenuItem.Font = new System.Drawing.Font("Chiller", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(70, 35);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(124, 36);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // txt_src
            // 
            this.txt_src.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txt_src.Location = new System.Drawing.Point(64, 93);
            this.txt_src.Name = "txt_src";
            this.txt_src.ReadOnly = true;
            this.txt_src.Size = new System.Drawing.Size(333, 20);
            this.txt_src.TabIndex = 6;
            // 
            // txt_dest
            // 
            this.txt_dest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txt_dest.Location = new System.Drawing.Point(64, 152);
            this.txt_dest.Name = "txt_dest";
            this.txt_dest.ReadOnly = true;
            this.txt_dest.Size = new System.Drawing.Size(333, 20);
            this.txt_dest.TabIndex = 7;
            // 
            // but_convert
            // 
            this.but_convert.Image = global::IsoAlgo_Gui.Properties.Resources.icon_c;
            this.but_convert.Location = new System.Drawing.Point(215, 193);
            this.but_convert.Name = "but_convert";
            this.but_convert.Size = new System.Drawing.Size(61, 59);
            this.but_convert.TabIndex = 2;
            this.but_convert.UseVisualStyleBackColor = true;
            this.but_convert.Click += new System.EventHandler(this.but_convert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(490, 273);
            this.Controls.Add(this.txt_dest);
            this.Controls.Add(this.txt_src);
            this.Controls.Add(this.lbl_dest);
            this.Controls.Add(this.lbl_src);
            this.Controls.Add(this.but_convert);
            this.Controls.Add(this.but_src);
            this.Controls.Add(this.but_dest);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "IsoAlgo Beta 0.6.9";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_dest;
        private System.Windows.Forms.Button but_src;
        private System.Windows.Forms.Button but_convert;
        private System.Windows.Forms.Label lbl_src;
        private System.Windows.Forms.Label lbl_dest;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox txt_src;
        private System.Windows.Forms.TextBox txt_dest;
    }
}

