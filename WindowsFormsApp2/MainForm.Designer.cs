namespace WindowsFormsApp2
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.produseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiuniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parteneriToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.intrariToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iesiriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rapoarteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produseToolStripMenuItem,
            this.gestiuniToolStripMenuItem,
            this.parteneriToolStripMenuItem1,
            this.intrariToolStripMenuItem,
            this.iesiriToolStripMenuItem,
            this.rapoarteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1141, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // produseToolStripMenuItem
            // 
            this.produseToolStripMenuItem.Name = "produseToolStripMenuItem";
            this.produseToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.produseToolStripMenuItem.Text = "Produse";
            this.produseToolStripMenuItem.Click += new System.EventHandler(this.produseToolStripMenuItem_Click);
            // 
            // gestiuniToolStripMenuItem
            // 
            this.gestiuniToolStripMenuItem.Name = "gestiuniToolStripMenuItem";
            this.gestiuniToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.gestiuniToolStripMenuItem.Text = "Gestiuni";
            this.gestiuniToolStripMenuItem.Click += new System.EventHandler(this.gestiuniToolStripMenuItem_Click);
            // 
            // parteneriToolStripMenuItem1
            // 
            this.parteneriToolStripMenuItem1.Name = "parteneriToolStripMenuItem1";
            this.parteneriToolStripMenuItem1.Size = new System.Drawing.Size(79, 24);
            this.parteneriToolStripMenuItem1.Text = "Parteneri";
            this.parteneriToolStripMenuItem1.Click += new System.EventHandler(this.parteneriToolStripMenuItem1_Click);
            // 
            // intrariToolStripMenuItem
            // 
            this.intrariToolStripMenuItem.Name = "intrariToolStripMenuItem";
            this.intrariToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.intrariToolStripMenuItem.Text = "Intrari";
            this.intrariToolStripMenuItem.Click += new System.EventHandler(this.intrariToolStripMenuItem_Click);
            // 
            // iesiriToolStripMenuItem
            // 
            this.iesiriToolStripMenuItem.Name = "iesiriToolStripMenuItem";
            this.iesiriToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.iesiriToolStripMenuItem.Text = "Iesiri";
            this.iesiriToolStripMenuItem.Click += new System.EventHandler(this.iesiriToolStripMenuItem_Click);
            // 
            // rapoarteToolStripMenuItem
            // 
            this.rapoarteToolStripMenuItem.Name = "rapoarteToolStripMenuItem";
            this.rapoarteToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.rapoarteToolStripMenuItem.Text = "Rapoarte";
            this.rapoarteToolStripMenuItem.Click += new System.EventHandler(this.rapoarteToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 517);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem produseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiuniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem intrariToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iesiriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rapoarteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parteneriToolStripMenuItem1;
    }
}

