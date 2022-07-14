namespace View
{
    partial class FormMain
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
            this.racunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajRacunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.promeniRacunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obrisiRacunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transakcijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izmeniTransakcijuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obrisiTransakcijuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.izvestajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.racunToolStripMenuItem,
            this.izvestajToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1040, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // racunToolStripMenuItem
            // 
            this.racunToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajRacunToolStripMenuItem,
            this.promeniRacunToolStripMenuItem,
            this.obrisiRacunToolStripMenuItem,
            this.transakcijeToolStripMenuItem});
            this.racunToolStripMenuItem.Name = "racunToolStripMenuItem";
            this.racunToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.racunToolStripMenuItem.Text = "Racun";
            // 
            // dodajRacunToolStripMenuItem
            // 
            this.dodajRacunToolStripMenuItem.Name = "dodajRacunToolStripMenuItem";
            this.dodajRacunToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.dodajRacunToolStripMenuItem.Text = "Dodaj racun";
            this.dodajRacunToolStripMenuItem.Click += new System.EventHandler(this.dodajRacunToolStripMenuItem_Click);
            // 
            // promeniRacunToolStripMenuItem
            // 
            this.promeniRacunToolStripMenuItem.Name = "promeniRacunToolStripMenuItem";
            this.promeniRacunToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.promeniRacunToolStripMenuItem.Text = "Promeni racun";
            this.promeniRacunToolStripMenuItem.Click += new System.EventHandler(this.promeniRacunToolStripMenuItem_Click);
            // 
            // obrisiRacunToolStripMenuItem
            // 
            this.obrisiRacunToolStripMenuItem.Name = "obrisiRacunToolStripMenuItem";
            this.obrisiRacunToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.obrisiRacunToolStripMenuItem.Text = "Obrisi racun";
            this.obrisiRacunToolStripMenuItem.Click += new System.EventHandler(this.obrisiRacunToolStripMenuItem_Click);
            // 
            // transakcijeToolStripMenuItem
            // 
            this.transakcijeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izmeniTransakcijuToolStripMenuItem,
            this.obrisiTransakcijuToolStripMenuItem1});
            this.transakcijeToolStripMenuItem.Name = "transakcijeToolStripMenuItem";
            this.transakcijeToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.transakcijeToolStripMenuItem.Text = "Transakcije";
            this.transakcijeToolStripMenuItem.Click += new System.EventHandler(this.transakcijeToolStripMenuItem_Click);
            // 
            // izmeniTransakcijuToolStripMenuItem
            // 
            this.izmeniTransakcijuToolStripMenuItem.Name = "izmeniTransakcijuToolStripMenuItem";
            this.izmeniTransakcijuToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.izmeniTransakcijuToolStripMenuItem.Text = "Izmeni transakciju";
            this.izmeniTransakcijuToolStripMenuItem.Click += new System.EventHandler(this.izmeniTransakcijuToolStripMenuItem_Click);
            // 
            // obrisiTransakcijuToolStripMenuItem1
            // 
            this.obrisiTransakcijuToolStripMenuItem1.Name = "obrisiTransakcijuToolStripMenuItem1";
            this.obrisiTransakcijuToolStripMenuItem1.Size = new System.Drawing.Size(202, 26);
            this.obrisiTransakcijuToolStripMenuItem1.Text = "Obrisi transakciju";
            this.obrisiTransakcijuToolStripMenuItem1.Click += new System.EventHandler(this.obrisiTransakcijuToolStripMenuItem1_Click);
            // 
            // izvestajToolStripMenuItem
            // 
            this.izvestajToolStripMenuItem.Name = "izvestajToolStripMenuItem";
            this.izvestajToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.izvestajToolStripMenuItem.Text = "Izvestaj";
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlMain.Location = new System.Drawing.Point(12, 31);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1016, 682);
            this.pnlMain.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 725);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem racunToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izvestajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajRacunToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem promeniRacunToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obrisiRacunToolStripMenuItem;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.ToolStripMenuItem transakcijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izmeniTransakcijuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obrisiTransakcijuToolStripMenuItem1;
    }
}